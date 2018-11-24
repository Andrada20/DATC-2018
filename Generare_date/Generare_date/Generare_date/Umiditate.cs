using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generare_date
{
    class Umiditate
    {
        public float umiditate;
        public  Umiditate(float umiditate)
        {
            this.umiditate = umiditate;
        }
        public float GetUmiditateValoare(int min, int max)
        {
            Random valoare = new Random();
            float randomUmiditate = valoare.Next(min, max);
            return randomUmiditate;
        }
    }
}
