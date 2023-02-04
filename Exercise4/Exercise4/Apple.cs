using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Apple
    {

        #region Fields
        private float amountLeft;
        private bool organic;

        #endregion

        public float AmountLeft
        {
            get
            {
                return amountLeft;
            }
        }

        #region Properties
        public bool Organic
        {
            get
            {
                return organic;
            }
        }

        #endregion
    }
}
