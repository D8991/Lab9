using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
  public class Genre : Good, IGenre 
    {
        private string _Book_Author;
        private string _Book_Publisher;
        private Good _Book_Genre;
        public string Book_Author
        {
            get
            {
                if (String.IsNullOrEmpty(_Book_Author))
                    throw new Exception("Имя автора не может быть пустым");
                else
                    return _Book_Author;
            }
            set
            {
                _Book_Author = value;

            }
        }
        public string Book_Publisher
        {
            get
            {
                if (String.IsNullOrEmpty(_Book_Publisher))
                    throw new Exception("Издательство не может быть пустым");
                else
                    return _Book_Publisher;
            }
            set
            {
                _Book_Publisher = value;

            }
        }
        public Good Book_Genre {
            get
            {
                if (_Book_Genre == null)
                    throw new Exception("Жанр книги не может быть пустым");
                else
                    return _Book_Genre;
            }
    set
            {
                _Book_Genre = value;
            }
        }

        public Genre(Sale Good_Sale, string Book_Title, double Price, string Book_Author, string Book_Publisher, Sale Book_Genre) : base(Good_Sale, Book_Title, Price)
        {
            this.Book_Author = Book_Author;
            this.Book_Publisher = Book_Publisher;

        }
        public override string GoodInfo()
        {
            return "Наименоване товара: " + Good_Sale + "; " + "Заголовок: " + Book_Title + "; " + "Цена: " + Price + "; " + "Автор: " + Book_Author + "; " + "Издательство: " + Book_Publisher;
        }
    }
}
