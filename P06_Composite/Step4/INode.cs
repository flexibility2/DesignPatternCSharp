using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Composite.Step4
{
    public interface INode
    {
        void AppendAttributes(StringBuilder xml);
    }
}