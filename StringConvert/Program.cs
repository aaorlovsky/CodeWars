using System.Linq;

//string val = Console.ReadLine()!;

//Console.WriteLine(new string(val.ToLower().Select(ch => val.ToLower().Count(innerCh => ch == innerCh) == 1 ? '(' : ')').ToArray()));

//Console.WriteLine(val.ToLower().GroupBy(ch => ch).Where(g => g.Count() > 1).Count());


Console.WriteLine(FindMissingLetter(new char[] { 'O', 'Q', 'R', 'S' }));

static char FindMissingLetter(char[] array)
{
    for (var i = 0; i < array.Count() - 1; i++)
    {
        if ((int)array[i + 1] - (int)array[i] > 1)
        {
            return (char)((int)array[i] + 1);
        }

    }
    return ' ';
}


