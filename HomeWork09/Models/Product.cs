using System;
using System.Threading;

namespace Models
{
    public class Product
    {
        static int nextId;
        public int Id { get; set; } = Interlocked.Increment(ref nextId);
        public string Name { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }

        
    }
   

}