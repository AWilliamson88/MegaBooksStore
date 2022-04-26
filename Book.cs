using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Name: Andrew Williamson / P113357.
// Date Started: 09/06/2021.
// Date Finished: 17/06/2021.
namespace MegaBooksStore
{
    [Serializable]
    class Book
    {
        // isbn, author, title, publisher, price and date
        private int isbn;
        private double price;
        private string author;
        private string title;
        private string publisher;
        private string date;

        // Getters and setters for the private variables.
        public int GetISBN()
        {
            return isbn;
        }

        public void SetISBN(int newISBN)
        {
            isbn = newISBN;
        }

        public double GetPrice()
        {
            return price;
        }
        public void SetPrice(double newPrice)
        {
            price = newPrice;
        }

        public string GetAuthor()
        {
            return author;
        }
        public void SetAuthor(string newAuthor)
        {
            author = newAuthor;
        }

        public string GetTitle()
        {
            return title;
        }
        public void SetTitle(string newTitle)
        {
            title = newTitle;
        }

        public string GetPublisher()
        {
            return publisher;
        }
        public void SetPublisher(string newPublisher)
        {
            publisher = newPublisher;
        }

        public string GetDate()
        {
            return date;
        }
        public void SetDate(string newDate)
        {
            date = newDate;
        }

        public string DisplayBook()
        {
            return GetISBN() + " - " +
                    GetTitle() + " - " +
                    GetAuthor();
        }

    }
}
