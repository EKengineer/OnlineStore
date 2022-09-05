using System;

namespace Store
{
    public class Product
    {
        private int instCounter = 1;
        public int Id { get; }
        public string Name { get; }
        public decimal Cost { get; }
        public string Description { get; }

        public Product ( string name, decimal cost, string description)
        {
            Id = instCounter;
            Name = name;
            Cost = cost;
            Description = description;

            instCounter += 1;
        }

        public override string ToString()
        {
            return $"{Id}\n{Name}\n{Cost}";
        }
    }
}
