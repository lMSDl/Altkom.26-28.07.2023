using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Structural.PrivateClassData
{
    internal class ClassData
    {
        //private /*readonly*/ int _intValue;
        //private string _stringValue;

        private PrivateClassData _privateClassData;

        public ClassData(int intValue, string stringValue)
        {
            /*_intValue = intValue;
            _stringValue = stringValue;*/
            _privateClassData = new PrivateClassData(intValue, stringValue);
        }

        public void DoSth()
        {

            _privateClassData.GetStringValue();
            _privateClassData.GetIntValue();

            //_stringValue = "";
        }
    }
}
