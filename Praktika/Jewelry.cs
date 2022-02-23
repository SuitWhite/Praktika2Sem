using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{
    class Jewelry
    {
        private int id = 0;
        private string title = "";
        private string code = "";
        private string material = "";
        private string type = "";
        private DateTime date_of_creation = new DateTime();
        private int price = 0;

        public Jewelry(
        int id1,
        string title1,
        string code1,
        string material1,
        string type1,
        DateTime date_of_creation1,
        int price1)
        {
            id = Validation.id_validation(id1);

            title = Validation.title_validation(title1);
            code = Validation.code_validation(code1);
            material = Validation.material_validation(material1);
            type = Validation.type_validation(type1);
            date_of_creation = Validation.date_validation(date_of_creation1);

            price = Validation.id_validation(id1);
        }

        public override String ToString()
        {
            return $"{this.id.ToString()},\n{this.title},\n{this.code}," +
                   $"\n{this.material},\n{this.type},\n{this.date_of_creation.ToString()}," +
                   $"\n{this.price.ToString()}";
        }
    }
}
