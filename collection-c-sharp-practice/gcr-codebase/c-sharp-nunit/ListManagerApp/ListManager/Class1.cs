using System;
using System.Collections.Generic;

namespace ListManagerApp
{
    public class ListManager
    {
        // Add element to list
        public void AddElement(List<int> list, int element)
        {
            if (list != null)
            {
                list.Add(element);
            }
        }

        // Remove element from list
        public void RemoveElement(List<int> list, int element)
        {
            if (list != null)
            {
                list.Remove(element);
            }
        }

        // Get size of list
        public int GetSize(List<int> list)
        {
            if (list != null)
            {
                return list.Count;
            }
            return 0;
        }
    }
}
