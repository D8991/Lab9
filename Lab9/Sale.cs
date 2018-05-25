using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
   public class Sale
    {
        private string _Sale_Name;
      public string Sale_Name
             
            {
            get
            {
                if (String.IsNullOrEmpty(_Sale_Name))
                    throw new Exception("Наименование товара не может быть пустым");
                else
                    return _Sale_Name;
            }
    set
            {
                _Sale_Name = value;
            }
        }
            public Sale(string Sale_Name)
            {
                this.Sale_Name = Sale_Name;
            }
            public override string ToString()
            {
                return Sale_Name;
            }
        }
    }

