// Written by Jay Gunderson
// 08/18/2024


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Chapter_27_
{
    internal class AudioBook : ILibraryItem
    {
        // Class variables
        private string title = "n/a";
        private string author = "n/a";
        private int publicationYear = -1;
        private int duration = -1; // In Minutes
        private bool isAvailable = true;


        // Gets and Sets
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }

        public int PublicationYear
        {
            get { return this.publicationYear; }
            set { this.publicationYear = value; }
        }

        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }


        public bool IsAvailable
        {
            get { return this.isAvailable; }
        }

        // Constructors

        public AudioBook(string aTitle, string anAuthor, int aPublicationYear, int aDuration)
        {
            this.Title = aTitle;
            this.Author = anAuthor;
            this.PublicationYear = aPublicationYear;
            this.Duration = aDuration;
        }

        public AudioBook() : this("n/a", "n/a", -1, -1)
        {
            // empty constructor
        }

        // Methods

        public string GetInfo()
        {
            string msg = "";
            msg += "Title: " + this.Title + "\n";
            msg += "Author: " + this.Author + "\n";
            msg += "Publication Year: " + this.PublicationYear + "\n";
            msg += "Duration: " + this.Duration + " minutes" + "\n";
            return msg;
        }


        public void CheckOut()
        {
            if (this.IsAvailable)
            {
                isAvailable = false;
            }
            else
            {
                throw new InvalidOperationException("This item is already checked out");
            }
        }

        public void ReturnItem()
        {

            if (!this.IsAvailable)
            {
                isAvailable = true;
            }
            else
            {
                throw new InvalidOperationException("This item is not checked out");
            }
        }
    }
}
