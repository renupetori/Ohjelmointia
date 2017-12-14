using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;


namespace Kertaustehtävä_30._11
{
    class Toiminnot
    {

        private string _input;


        public Toiminnot(string input)
        {

            _input = input;
            
            _input = new System.Globalization.CultureInfo("en-US", false).TextInfo.ToTitleCase(_input.ToLower());
            
            if (_input.Contains(" The ") == true){
                _input = _input.Replace(" The ", " the ");
            }

            if (_input.Contains(" Of ") == true)
            {
                _input = _input.Replace(" Of ", " of ");
            }

        }

        

        public string Tulostus()
        {

            return _input;

        }

    }
}
