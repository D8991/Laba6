﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale book_Sale = new Sale("Книга");
            Sale journal_Sale = new Sale("Журнал");
            Sale genre_Sale = new Sale("Детектив");

            Book good1 = new Book(book_Sale, "Десять негритят", 250, "Агата Кристи", "Детектив", "Э");
            Book good2 = new Book(book_Sale, "Мастер и маргарита", 300, "Булгаков", "Роман", "Эксмо");
            Journal good3 = new Journal(journal_Sale, "Наука", 150, new DateTime(2018 / 02 / 15));
            Journal good4 = new Journal(journal_Sale, "Вестник", 140, new DateTime(2018 / 01 / 17));
            Genre good5 = new Genre(book_Sale, "Десять негритят", 250, genre_Sale);

            List<Good> ListGood = new List<Good>();
            ListGood.Add(good1);
            ListGood.Add(good2);
            ListGood.Add(good3);
            ListGood.Add(good4);
            ListGood.Add(good5);
            foreach (Good g in ListGood)
            {
                Console.WriteLine(g.gd());
            }
            Console.WriteLine("Из них детективы");
            foreach (Good g in ListGood.Where(i1 => i1 is IGenre))
            {
                Console.WriteLine(g.gd());
            }
            Console.ReadLine();
        }
    }
}
