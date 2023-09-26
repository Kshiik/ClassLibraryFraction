using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFraction
{

    public class Class1
    {
        /// <summary>
        /// формирует и проверяет дробь
        /// </summary>
        /// <param name="text">дробь</param>
        /// <returns>метод возращает дробь</returns>
        /// <exception cref="ArgumentException"></exception>
        public string FixWornResult(string text) 
        {
            string[] parts = text.Split('/');
            if (parts.Length != 2 ) 
            {
                throw new ArgumentException("в строке не две части");
            }

            int numb1;
            int numb2;
            if (!int.TryParse(parts[0], out numb1))
            {
                throw new ArgumentException("числитель не явлется числом");
            }
            if (!int.TryParse(parts[1], out numb2))
            {
                throw new ArgumentException("знаменатель не явлется числом");
            }
            if (numb1 > numb2) 
            {
                numb1= numb2;
            }

            return (numb1+"/"+numb2);
        }
    }
}
