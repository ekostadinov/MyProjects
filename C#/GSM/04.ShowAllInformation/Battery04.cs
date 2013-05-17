using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _04.ShowAllInformation
{
    class Battery04
    {
        //private override string ToString() { }
        private string type;

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        //public override string ToString()
        //{
        //    string battType = type.ToString();
        //    return "battery type: " + type + " " + battType;
        //}
               
    }
}
