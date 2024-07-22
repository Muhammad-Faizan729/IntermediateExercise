using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate
{
    public class Person
    {
        private DateTime _birthday;

        public Person()
        {

        }

        public void SetBirthday(DateTime birth)
        {
            this._birthday = birth;
        }

        public DateTime GetBirthday()
        {
            return this._birthday;
        }
    }
}
