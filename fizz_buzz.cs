using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fizz_buzz_rekord
{
    class fizz_buzz
    {
        public string tekst;
        
        public string fizzbuzz(int liczba)
        {
            if (liczba % 3 == 0 && liczba % 5 == 0)
                tekst = "FIZZ BUZZ";
            else if (liczba % 3 == 0)
                tekst = "Fizz";
            else if (liczba % 5 == 0)
                tekst = "Buzz";            
            else
                tekst = liczba.ToString();

            return tekst;
        }
    }
}
