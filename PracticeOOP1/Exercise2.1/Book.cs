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
        private Author Author;
        private double Price;
        private int Qty = 0;

        public Book(String name, Author author, double price, int qty = 0)
        {
            this.Name = name;
            this.Author = author;
            this.Price = price;
            this.Qty = qty;
        }

        public string GetName()
        {
            return this.Name;
        }

        public Author GetAuthor()
        {
            return this.Author;
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

            return string.Format("Book[Name = {0}, {1}, price={2}, Qty={3}]", this.Name, this.Author, this.Price, this.Qty);
        }

        public String GetAuthorName ()
        {
            return this.Author.GetName();
        }
        public String GetAuthorEmail()
        {
            return this.Author.GetEmail();
        }
        public char GetAuthorGender()
        {
            return this.Author.GetGender();
        }
    }
}
