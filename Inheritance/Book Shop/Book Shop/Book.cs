using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Shop
{
    class Book
    {
        private string author, title;
        private double price;
        public Book(String author, String title, double price)
        {
            this.setAuthor(author);

            this.setTitle(title);

            this.setPrice(price);
        }
        public string Author
        {
            get
            {
                return this.author;
            }
            set

            {

                if (value == "") {
                    throw new ArgumentException("the book must have an autor.");
                }
                this.author = value;

            }

        }

        public string Title{
            get

            {
                return this.title;
            }
            set

            {
                if (value == "")
                {
                    throw new ArgumentException("the book must have a title.");
                }
                this.title = value;
            }
        }

        public virtual double Price
        {
            get { return this.price; }
            set
            {
                if (value == 0.00)
                {
                    throw new ArgumentException("the book must have a Price.");
                }
 
                this.price = value; }
        }

        
        public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Type: ").Append(this.GetType().Name)
                .Append(Environment.NewLine)
                .Append("Title: ").Append(this.Title)
                .Append(Environment.NewLine)
                .Append("Author: ").Append(this.Author)
                .Append(Environment.NewLine)
                .Append("Price: ").Append(this.Price)
                .Append(Environment.NewLine);
                return sb.ToString();

            }
        }
}
