using System.Collections.Generic;

namespace PP_22_02_25_NUnit
{
    public class ListManager
    {
        public void AddElement(List<int> list, int element) => list.Add(element);
        public void RemoveElement(List<int> list, int element) => list.Remove(element);
        public int GetSize(List<int> list) => list.Count;
    }
}
