using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class GettersAndSetters
    {
        private int _x;
        private readonly int _y = 15;

        public int x        //Create getter and setters for x
        {
            
            get
            {
                return this._x;
            }
            set {
                if(value < 0)
                {
                    throw new Exception("Value must be greater than 0!");
                }
                _x = value; 
            }
        }

        public int y            // y is a read only method so Setters is not written
        {
            get
            {
                return this._y;
            }

        }

        public int z { get; set; }      //auto implemented properties 

    }
}
