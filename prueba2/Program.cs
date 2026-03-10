
string? name = "caba";

string? sorted = new string(name.OrderBy(c => c).ToArray());
Console.WriteLine(sorted);