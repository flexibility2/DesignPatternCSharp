using P06_Composite.Step3_Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Composite.Step4
{
    public class Order : INode
    {
        public string Id { get; set; }
        public List<INode> Products { get; set; }
        public decimal TotalPrice { get; set; }

        public Order()
        {
            Products = new List<INode>();
        }

        public void AppendAttributes(StringBuilder xml)
        {
            xml.Append("<order");
            xml.Append(" id='");
            xml.Append(this.Id);
            xml.Append("' totalPrice='");
            xml.Append(this.TotalPrice);
            xml.Append("'>");
            Products.ForEach((node) => { node.AppendAttributes(xml); });
            //WriteProductsTo(xml, order);
            xml.Append("</order>");
        }
    }
}