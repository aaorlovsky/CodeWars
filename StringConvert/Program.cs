using System.Linq;

string val = Console.ReadLine()!;

Console.WriteLine(new string(val.ToLower().Select(ch => val.ToLower().Count(innerCh => ch == innerCh) == 1 ? '(' : ')').ToArray()));



