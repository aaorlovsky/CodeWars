var val = int.Parse(Console.ReadLine()!);

var bitArray = new System.Collections.BitArray(BitConverter.GetBytes(val));
var count = 0;
foreach (bool bit in bitArray)
{
    if (bit)
    {
        count++;
    }
}
Console.WriteLine(count);

