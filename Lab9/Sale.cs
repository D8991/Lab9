using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
   public class Sale
    {
      public string Sale_Name{ get; set; }
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

