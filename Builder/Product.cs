using System;
using System.Collections.Generic;

namespace OO_Design_Patterns.Builder
{
    public class Product
    {
        private IList<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("Start Show");
            foreach (var part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}