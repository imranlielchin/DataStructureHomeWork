using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureHW
{
    internal class Book
    {
        string Name;
        string AuthorName;   
        int PublishedDate;
        int PageCount;
        
        public Book(string name, string author, int page, int date)
        { 
            this.Name = name;
            this.PublishedDate = date;
            this.AuthorName = author;   
            this.PageCount = page;
        }   
        public override string ToString() 
        {
            return ($"{AuthorName} \"{Name}\" {PublishedDate}");
        }
        
        public void ReturnFullInfo()
        {
            Console.WriteLine($"Eserin adi:{Name}\nMuellifin adi:{AuthorName}\nNesr ili:{PublishedDate}\nSehife sayi:{PageCount}");

        }




    }
    

}
