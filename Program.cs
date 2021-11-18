using System;

namespace compositionlab
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Author myAuthor = new Author("Jeff Lucas", 'm', "jslucas@cba.ua.edu");
            Author yourAuthor= new Author("Jamie", 'f', "jamie@crimson.ua.edu");
            // yourAuthor.SetEmail("jamie@crimson.ua.edu");
            System.Console.WriteLine(yourAuthor.GetEmail() + " ");

            Book myBook= new Book ("1234", "My Book, Your Book", myAuthor);

            Book yourBook= new Book("4321", "The Phantom Book", new Author("asdf", 'f', "jamie@mail.com"));
            
            System.Console.WriteLine(yourBook.ToString());
            
            yourBook.GetAuthor().SetEmail("jamie@crimson.ua.edu");
           
            System.Console.WriteLine(myAuthor.ToString());
        
            System.Console.WriteLine(myBook.ToString());
    
            System.Console.WriteLine(yourBook.ToString());
        
            System.Console.WriteLine(myBook.GetAuthor().ToString());

            System.Console.WriteLine(yourAuthor.ToString());

        }
    }
}
