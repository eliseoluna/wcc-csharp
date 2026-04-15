using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10
{
    internal class ProductionWorker : Employee
    {
        #region Properties
        private int _shiftNum;
        private double _hourlyRate;
        #endregion

        #region Constructors
        public ProductionWorker() // Default Constructor
        {
            _shiftNum = ShiftNum;
            _hourlyRate = HourlyRate;
        }
        #endregion

        #region Accessors
        public int ShiftNum
        {
            get
            {
                return _shiftNum;
            }
            set
            {
                _shiftNum = value;
            }
        }
        public double HourlyRate
        {
            get
            {
                return _hourlyRate;
            }
            set
            {
                _hourlyRate = value;
            }
        }
        #endregion
    }
}
