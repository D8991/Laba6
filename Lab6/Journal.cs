using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Journal: Good
    {
        public DateTime DataOfPublic { get; set; }


        public Journal(Sale Good_Name, string Book_Title, double Price, DateTime DataOfPublic) : base(Good_Name, Book_Title, Price)
        {
            this.DataOfPublic = DataOfPublic;

        }
        public override string gd()
        {
       
           return "Название товара: "+ Good_Name + ";"+"Заголовок: " + Book_Title + ";"+"Цена: "  + Price + ";"+"Дата издания: " + DataOfPublic;

        }
    }
}
