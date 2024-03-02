using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._6._6
{
    public class Account : IAccount
    {
        // тип учетной записи
        public string Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public void CalculateInterest()
        {
            if (Type == "Обычный")
            {
                Interest = Balance * 0.4;

                if (Balance < 1000)
                    Interest -= Balance * 0.2;
                else
                    Interest -= Balance * 0.4;
            }
            else if (Type == "Зарплатный")
            {
                Interest = Balance * 0.5;
            }
        }
    }
}
