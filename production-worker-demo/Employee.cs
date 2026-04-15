using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10
{
    internal class Employee
    {
        #region Properties
        private string _name;
        private int _number;
        #endregion

        #region Constructors
        public Employee() // Default Constructor
        {
            _name = Name;
            _number = Number;
        }
        #endregion

        #region Accessors
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
        #endregion
    }
}
