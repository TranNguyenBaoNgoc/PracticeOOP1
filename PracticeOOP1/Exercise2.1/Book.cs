using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2._1
{
    public class Book
    {
        private string Name;
        private Author [] Authors;
        private double Price;
        private int Qty = 0;

        public Book(String name, Author [] author, double price, int qty = 0)
        {
            this.Name = name;
            this.Authors = author;
            this.Price = price;
            this.Qty = qty;
        }

        public string GetName()
        {
            return this.Name;
        }

        public Author [] GetAuthors()
        {
            return this.Authors;
        }

        public double GetPrice()
        {
            return this.Price;
        }

        public void SetPrice(double price)
        {
            this.Price= price;
        }

        public int GetQty()
        {
            return this.Qty;
        }

        public void SetQty(int qty)
        {
            this.Qty = qty;
        }
        public override string ToString()
        {
            string[] StrAuthors = new string[this.Authors.Length];
            for (int i = 0; i < this.Authors.Length; i++)
            {
                StrAuthors[i] = this.Authors[i].ToString();
            }
            return string.Format("Book[Name = {0}, authors = {{{1}, price={2}, Qty={3}]", this.Name, string.Join(",", StrAuthors), this.Price, this.Qty);
        }
        public string GetAuthorNames()
        {
            string[] StrAuthors = new string[this.Authors.Length];
            for (int i = 0; i < this.Authors.Length; i++)
            {
                StrAuthors[i] = this.Authors[i].ToString();
            }
            return string.Join(",", StrAuthors);
        }
    }
}
