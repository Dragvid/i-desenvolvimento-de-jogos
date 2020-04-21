using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Shop
{
    class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string author, string title, double price) : base(author, title, price)
        {
        }

        public override double Price
        {
            get
            {

                return base.Price * 1.3;

            }
            /*set {
                base.Price = value;
            }*/
        }
    }
}
