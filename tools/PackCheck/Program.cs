using System.Text.Json;
using Lumina.Text.ReadOnly;

if (args is ["--self-test"])
{
    string[] valid = [@"\<scricchiolio> Addestramento completato.<br>Sei pari a Drusilla.",
        @"Ottieni <kilo(lnum2,\,)><if([lnum3>0],\(+<kilo(lnum3,\,)>\),)> punti.",
        "<if(gnum4,avventuriera,avventuriero)>"];
    string[] invalid = ["<creak> Addestramento completato.",
        @"<if([lnum3>0],\(+<kilo(lnum3,\,)>),)>"];
    foreach (var text in valid) _ = ReadOnlySeString.FromMacroString(text);
    foreach (var text in invalid)
    {
        var rejected = false;
        try { _ = ReadOnlySeString.FromMacroString(text); }
        catch (Exception) { rejected = true; }
        if (!rejected) throw new InvalidOperationException($"Invalid macro accepted: {text}");
    }
    Console.WriteLine("5 macro regression checks passed.");
    return;
}

if (args is ["--inspect", var file, var inspectKey])
{
    using var doc = JsonDocument.Parse(File.ReadAllText(file));
    var entry = doc.RootElement.GetProperty("entries").EnumerateArray()
        .Single(e => e.GetProperty("gameKey").GetString() == inspectKey);
    var value = ReadOnlySeString.FromMacroString(entry.GetProperty("target").GetString()!);
    Console.WriteLine(value.ToString());
    foreach (var payload in value) Console.WriteLine(payload.ToString());
    return;
}

if (args.Length != 1 && !(args.Length == 3 && args[1] == "--english"))
{
    Console.Error.WriteLine("Usage: PackCheck <file-or-directory> [--english <EN-repository>] | --inspect <file> <gameKey> | --self-test");
    Environment.ExitCode = 2;
    return;
}

var path = Path.GetFullPath(args[0]);
if (!File.Exists(path) && !Directory.Exists(path)) throw new FileNotFoundException(path);
var files = File.Exists(path) ? [path] : Directory.GetFiles(path, "*.json", SearchOption.AllDirectories);
var root = new DirectoryInfo(File.Exists(path) ? Path.GetDirectoryName(path)! : path);
while (root is not null && !File.Exists(Path.Combine(root.FullName, "pack.json"))) root = root.Parent;
if (root is null) throw new InvalidOperationException("Input must belong to a language pack (pack.json).");
var english = args.Length == 3 ? Path.GetFullPath(args[2]) : null;
int fields = 0, empty = 0, errors = 0;
void Error(string message) { Console.Error.WriteLine(message); errors++; }
foreach (var current in files.Order())
{
    try
    {
        using var doc = JsonDocument.Parse(File.ReadAllText(current));
        var relative = Path.GetRelativePath(root.FullName, current);
        Dictionary<string, string?>? source = null;
        if (english is not null)
        {
            using var en = JsonDocument.Parse(File.ReadAllText(Path.Combine(english, relative)));
            source = en.RootElement.GetProperty("entries").EnumerateArray()
                .ToDictionary(e => e.GetProperty("gameKey").GetString()!, e => e.GetProperty("hash").GetString());
        }
        var seen = new HashSet<string>();
        foreach (var entry in doc.RootElement.GetProperty("entries").EnumerateArray())
        {
            var key = entry.GetProperty("gameKey").GetString()!;
            fields++;
            if (!seen.Add(key)) Error($"{relative}#{key}: duplicate gameKey");
            if (source is not null && (!source.TryGetValue(key, out var hash) || hash != entry.GetProperty("hash").GetString()))
                Error($"{relative}#{key}: missing English entry or hash mismatch");
            var target = entry.GetProperty("target").GetString();
            if (string.IsNullOrEmpty(target)) { empty++; continue; }
            if (target.Contains("<hex:", StringComparison.OrdinalIgnoreCase))
                Error($"{relative}#{key}: raw hex is forbidden");
            try { _ = ReadOnlySeString.FromMacroString(target); }
            catch (Exception ex) { Error($"{relative}#{key}: {ex.Message}"); }
        }
    }
    catch (Exception ex) { Error($"{current}: {ex.Message}"); }
}
Console.WriteLine($"{files.Length} files, {fields} fields, {empty} empty targets, {errors} errors.");
Environment.ExitCode = errors == 0 ? 0 : 1;
