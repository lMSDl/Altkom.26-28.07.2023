using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DP.SOLID.I
{
    /*interface IFormatter
    {
        void ToExcel();
        void ToPdf();
    }*/
    interface IPdfFormatter
    {
        void ToPdf();
    }
    interface IExcelFormatter
    {
        void ToExcel();
    }
    /*interface IFormatter : IPdfFormatter, IExcelFormatter
    {
    }*/

    class Report : IPdfFormatter, IExcelFormatter
    {
        public void ToExcel()
        {
            Console.WriteLine("Excel generated");
        }

        public void ToPdf()
        {
            Console.WriteLine("Pdf generated");
        }
    }

    class Poem : IPdfFormatter, IConvertible
    {
        public void ToPdf()
        {
            Console.WriteLine("Pdf generated");
        }
    }

}
