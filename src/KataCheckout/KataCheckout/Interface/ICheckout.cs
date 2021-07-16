using System;
using System.Collections.Generic;
using System.Text;

namespace KataCheckout
{
   public interface ICheckout
    {
        void Scan(string item);

        int GetTotalPrice();
    }
}
