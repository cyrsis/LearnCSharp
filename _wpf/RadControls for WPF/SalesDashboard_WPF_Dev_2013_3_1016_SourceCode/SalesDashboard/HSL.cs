using System;

namespace SalesDashboard
{
    public class HSL
    {
        #region Class Variables
        public HSL()
        {
            _h = 0;
            _s = 0;
            _l = 0;
        }

        double _h;
        double _s;
        double _l;

        #endregion

        #region Public Methods

        public double H
        {
            get
            {
                return _h;
            }
            set
            {
                _h = value;
                _h = _h > 1 ? 1 : _h < 0 ? 0 : _h;
            }
        }

        public double S
        {
            get
            {
                return _s;
            }
            set
            {
                _s = value;
                _s = _s > 1 ? 1 : _s < 0 ? 0 : _s;
            }
        }

        public double L
        {
            get
            {
                return _l;
            }
            set
            {
                _l = value;
                _l = _l > 1 ? 1 : _l < 0 ? 0 : _l;
            }
        }
        #endregion
    }
}
