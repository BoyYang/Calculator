using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyInterface;

namespace LibAdd
{
    public class Add:ICaculatable
    {
        private int _num1;
        private int _num2;

        public Add(int num1,int num2)
        {
            this._num1 = num1;
            this._num2 = num2;
        }
        
        public int GetResult()
        {
            return this._num1 + this._num2;
        }

        public string Opertation
        {
            get { return "+" }
        }
    }
}
