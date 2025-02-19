using System;
using System.Collections.Generic;

namespace PP_19_02_25
{
    class InvertAMap
    {
        static Dictionary<V, List<K>> InvertDictionary<K, V>(Dictionary<K, V> originalDict)
        {
            Dictionary<V, List<K>> invertedDict = new Dictionary<V, List<K>>();

            foreach (var kvp in originalDict)
            {
                V value = kvp.Value;
                K key = kvp.Key;

                if (invertedDict.ContainsKey(value))
                {
                    invertedDict[value].Add(key);
                }
                else
                {
                    invertedDict[value] = new List<K> { key };
                }
            }

            return invertedDict;
        }

        public static void Main15()
        {
            // Original dictionary
            Dictionary<string, int> originalDict = new Dictionary<string, int>
        {
            { "A", 1 },
            { "B", 2 },
            { "C", 1 }
        };

            // Invert the dictionary
            Dictionary<int, List<string>> invertedDict = InvertDictionary(originalDict);

            // Print the inverted dictionary
            Console.WriteLine("Inverted Dictionary:");
            foreach (var kvp in invertedDict)
            {
                Console.WriteLine($"{kvp.Key} = [{string.Join(", ", kvp.Value)}]");
            }
        }
    }

}
