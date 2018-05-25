using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
   public class Sale
    {
        private string Sale_name;
      public string Sale_Name
             
            {
            get
            {
                if (String.IsNullOrEmpty(Sale_name))
                    throw new Exception("Наименование товара не может быть пустым");
                else
                    return Sale_Name;
            }
    set
            {
                Sale_Name = value;
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

