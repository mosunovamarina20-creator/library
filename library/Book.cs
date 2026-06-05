using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class Book
    {
        public string Title;
        public string Autor;
        public int Year;
        public bool IsAvailable;

        public Book()
        {
            Title = "Неизвестная книга";
            Autor = "Неизвестный автор";
            Year = 0;
            IsAvailable = true;
        }

        public Book(string title, string autor, int year, bool isAvailable)
        {
            Title = title;
            Autor = autor;
            Year = year;
            IsAvailable = isAvailable;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Название: {Title}");
            Console.WriteLine($"Автор: {Autor}");
            Console.WriteLine($"Год издания: {Year}");
            Console.WriteLine($"Статус книги: {IsAvailable}");
            if(IsAvailable)
            {
                Console.WriteLine("Доступна");
            }
            else
            {
                Console.WriteLine("Не доступна");
            }

        }
        
    }

}
