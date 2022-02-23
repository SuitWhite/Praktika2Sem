using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{
    static class Validation
    {
        static public int id_validation(int i)
        {
            if (i > 0)
            {
                return i;
            }
            else
            {
                throw new ArgumentException("Id value must be more than zero");
            }
        }

        static public string title_validation(string t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                if (!char.IsLetter(t[i]) || !char.IsDigit(t[i]))
                {
                    throw new ArgumentException("Wrong title");
                }
            }
            return t;
        }

        static public string code_validation(string t)
        {
            if (t.Length != 10)
                throw new ArgumentException("Size of code must be 10");
            for (int i = 0; i < 10; i++) {
                if (!char.IsDigit(t[i]) && i!=5 && i!=7)
                    throw new ArgumentException("Wrong code");
            }
            if (t[5] != '/' || t[7] != '-')
                throw new ArgumentException("Wrong code");
            return t;
        }

        static public string material_validation(string t)
        {
            if (t!="gold" && t!="silver" && t != "platinum")
            {
                throw new ArgumentException("Wrong material");
            }
            return t;
        }

        static public string type_validation(string t)
        {
            if (t != "rings" && t != "earrings" && t != "bracelets")
            {
                throw new ArgumentException("Wrong material");
            }
            return t;
        }

        static public DateTime date_validation(DateTime dateTime)
        {
            if (dateTime.Date > DateTime.Today || dateTime.Date < new DateTime(1900, 0, 0))
            {
                throw new ArgumentException("Wrong date");
            }
            return dateTime;
        }
    }

    
}
