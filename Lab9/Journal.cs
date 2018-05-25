using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
   public class Journal : Good
    {
        private DateTime _DateOfPublic;
        public DateTime DateOfPublic
        { 
        get
            {
                if (_DateOfPublic == null)
                    throw new Exception("Укажите дату публикации");
                else
                    return _DateOfPublic;
            }
    set
            {
                _DateOfPublic = value;
            }
        }


        public Journal(Sale Good_Sale, string Book_Title, double Price, DateTime DateOfPublic) : base(Good_Sale, Book_Title, Price)
        {
            this.DateOfPublic = DateOfPublic;

        }
        public override string GoodInfo()
        {

            return "Название товара: " + Good_Sale + ";" + "Заголовок: " + Book_Title + ";" + "Цена: " + Price + ";" + "Дата издания: " + DateOfPublic;

        }
    }
}
