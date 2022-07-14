using System;


string[] a = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
string[] b = DirReduction.dirReduc(a);


public class DirReduction
{
    public static string[] dirReduc(String[] arr)
    {
        String[] FromNorthToSouth = new String[] { "NORTH", "SOUTH" };
        String[] FromSouthToNorth = new String[] { "SOUTH", "NORTH" };
        String[] FromEastToWest = new String[] { "EAST", "WEST" };
        String[] FromWestToEast = new String[] { "WEST", "EAST" };

        var dirContainsNeedlessPath = true;
        while (dirContainsNeedlessPath)
        {
            for (var i = 0; i < arr.Count(); i++)
            {
                if (arr.Skip(i).Take(2).SequenceEqual(FromNorthToSouth) ||
                    arr.Skip(i).Take(2).SequenceEqual(FromSouthToNorth) ||
                    arr.Skip(i).Take(2).SequenceEqual(FromEastToWest) ||
                    arr.Skip(i).Take(2).SequenceEqual(FromWestToEast))
                {
                    List<string> arrTemp = arr.ToList();
                    arrTemp.RemoveRange(i, 2);
                    arr = arrTemp.ToArray();
                    break;
                }

                if (i == arr.Count() - 2 || arr.Count() < 2)
                {
                    dirContainsNeedlessPath = false;
                }
            }
        }

        return arr;
    }

}

