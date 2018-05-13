using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Genre: Good, IGenre
    {
        
       public Sale Book_Genre { get; set; }

        public Genre (Sale Good_Name, string Book_Title, double Price, Sale Book_Genre) : base (Good_Name, Book_Title, Price)
        {
        
        }
        public override string gd()
        {
            return Good_Name + "," + Book_Title + "," + Price + "," + Book_Genre;
        }
    }
}
