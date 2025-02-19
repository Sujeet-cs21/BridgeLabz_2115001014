using System;
using System.Collections.Generic;

namespace PP_19_02_25
{
    class RotateListByN
    {
        static List<int> RotateLeft(List<int> list, int positions)
        {
            int n = list.Count;
            positions = positions % n;

            if (positions == 0)
                return list;

            List<int> rotatedPart = list.GetRange(positions, n - positions);
            List<int> remainingPart = list.GetRange(0, positions);
            rotatedPart.AddRange(remainingPart);
            return rotatedPart;
        }


        public static void Main3()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            int positions = 2;

            List<int> rotatedList = RotateLeft(list, positions);
            Console.WriteLine("Rotated List: " + string.Join(", ", rotatedList));
        }
    }
}
