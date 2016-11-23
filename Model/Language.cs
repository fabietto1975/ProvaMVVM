using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Model
{
    public class Language
    {
        private string _name;
        private string _value;

        public string Name { get { return _name; } }
        public string Value { get { return _value; } }
        public Language(string name, string value)
        {
            _name = name;
            _value = value;
        }

    }
}
