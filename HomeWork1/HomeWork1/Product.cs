﻿namespace HomeWork1
{
    public class Product
    {
        private string name = String.Empty;
        private double weight;
        public double Price { get; private set; }

        public Product()
        { }

        public Product(string name, double price, double weight)
        {
            this.name = name;
            this.weight = weight;
            Price = price;
        }

        public override string ToString()
        {
            return $"Name: {name}\nWeight: {weight}\nPrice: {Price}\n";
        }
    }
}