using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public abstract class Good 
    {
        private Sale _Good_Sale;
        private string _Book_Title;
        private double _Price;
        public Sale Good_Sale
        {
             get
            {
                    if (Good_Sale==null)
               
                        throw new Exception("Наименование товара не может быть пустым");
                    else
                        return _Good_Sale;
                }
                set
            {
                    _Good_Sale = value;
                
            }
        }
    
        public string Book_Title
    {
        get
        {
            if (String.IsNullOrEmpty(Book_Title))
                throw new Exception("Заголовок не может быть пустым");
            else
                return _Book_Title;
        }
        set
        {
            _Book_Title = value;

        }
    }

public double Price
    {
        get
        {
            return _Price;
        }
        set
        {
            if (value > 0)
                _Price = value;
            else
                Console.WriteLine("Неверное значение цены");
        }
    }
    public Good (Sale Good_Sale, string Book_Title, double Price)
        {
            this.Good_Sale = Good_Sale;
            this.Book_Title = Book_Title;
            this.Price = Price;
        }
        public abstract string GoodInfo();
    }
}
