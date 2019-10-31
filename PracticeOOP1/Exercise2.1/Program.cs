using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Author ahTeck = new Author("Tan Ah Teck", "ahteck@nowhere.com", 'm'); // Test the constructor
            //Console.WriteLine(ahTeck);  // Test toString()
            //ahTeck.SetEmail("paulTan@nowhere.com");  // Test setter
            //Console.WriteLine("Name is: " + ahTeck.GetName());     // Test getter
            //Console.WriteLine("Eamil is: " + ahTeck.GetEmail());   // Test getter
            //Console.WriteLine("Gender is: " + ahTeck.GetGender()); // Test gExerciseOOP_MyPolynomial.pngetter

            Book dummyBook = new Book("Java for dummy", ahTeck, 19.95, 99);  // Test Book's Constructor
            Console.WriteLine(dummyBook);  // Test Book's toString()

            // Test Getters and Setters
            dummyBook.SetPrice(29.95);
            dummyBook.SetQty(28);
            Console.WriteLine("Name is: " + dummyBook.GetName());
            Console.WriteLine("Price is: " + dummyBook.GetPrice());
            Console.WriteLine("Qty is: " + dummyBook.GetQty());
            Console.WriteLine("Author is: " + dummyBook.GetAuthor());  // Author's toString()
            Console.WriteLine("Author's name is: " + dummyBook.GetAuthor().GetName());
            Console.WriteLine("Author's email is: " + dummyBook.GetAuthor().GetEmail());

            // Use an anonymous instance of Author to construct a Book instance
            Book anotherBook = new Book("more Java", 
                  new Author("Paul Tan", "paul@somewhere.com", 'm'), 29.95);
            Console.WriteLine(anotherBook);  // toString()
        }
    }
}
