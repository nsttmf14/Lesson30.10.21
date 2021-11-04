using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson30._10._21_onlylab
{
    class BankTransaction
    {
        public readonly DateTime date;
        public readonly TimeSpan time;
        public readonly double sum;

        public BankTransaction(double sum)
        {
            date = DateTime.Now.Date;
            time = DateTime.Now.TimeOfDay;
            this.sum = sum;
        }

        public override string ToString()
        {
            return $"{date.ToShortDateString()} {time} {sum}";
        }
    }
}
