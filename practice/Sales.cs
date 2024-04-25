using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Sales
    {
        public string name {  get; set; }
        public string SurName { get; set; }
        public string Tel { get; set; }
        public string Gender { get; set; }
        public string Sl1 { get; set; }
        public string Sl2 { get; set; }
        public string Sl3 { get; set; }

        public string Sl4 { get; set; }

        public Sales(string name, string SurName, string Tel,string Gender,string sl1, string sl2, string sl3, string sl4)
        {
            this.name = name;   
            this.SurName = SurName;
            this.Tel = Tel;
            this.Gender = Gender;
            this.Sl1 = sl1;
            this.Sl2 = sl2;
            this.Sl3 = sl3;
            this.Sl4 = sl4;
        }

    }
}
