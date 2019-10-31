using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2._1
{
    public class Author
    {
        private string Name, Email;
        private char Gender;
        public Author(string name, string email, Char gender)
        {
            this.Name = name;
            this.Email = email;
            this.Gender = gender;
        }

        public string GetName()
        {
            return this.Name;
        }

        public string GetEmail()
        {
            return this.Email;
        }

        public char GetGender()
        {
            return this.Gender;
        }

        public void SetEmail(string email)
        {
            this.Email = email;
        }

        public override string ToString()
        {
            
            return string.Format("Author[Name = {0}, email = {1}, gender = {2}]", this.Name, this.Email,this.Gender);
        }
    }
}
