using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments05_OOp
{
    public interface ICircle : IShape
    {
        double Radius { get; set; }
    }
}
