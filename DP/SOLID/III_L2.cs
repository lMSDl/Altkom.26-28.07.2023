using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.SOLID.L
{
    //ZŁAMANIE ZASADY LSP

    public abstract class Shape
    {
        public abstract uint Area { get; }
    }

    public class Square : Rectangle
    {
        public override uint A { set => base.A = base.B = value; }
        public override uint B { set => base.B = base.A = value; }
    }

    public class Rectangle : Shape
    {
        public virtual uint A { get; set; }
        public virtual uint B { get; set; }

        public override uint Area => A * B;
    }
}
