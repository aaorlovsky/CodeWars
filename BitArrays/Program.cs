var val = int.Parse(Console.ReadLine()!);

Console.WriteLine(System.Numerics.BitOperations.PopCount((uint)val));
//best practice

//my solution
/*var bitArray = new System.Collections.BitArray(BitConverter.GetBytes(val));
var count = 0;
foreach (bool bit in bitArray)
{
    if (bit)
    {
        count++;
    }
}
Console.WriteLine(count);*/

