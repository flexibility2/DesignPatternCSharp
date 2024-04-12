using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Composite.Step4
{
    public class OrderWriter
    {
        private List<Order> _orders;

        public OrderWriter(List<Order> orders)
        {
            _orders = orders;
        }

        public String GetContents()
        {
            StringBuilder xml = new StringBuilder();
            WriteOrdersTo(xml);
            return xml.ToString();
        }

        private void WriteOrdersTo(StringBuilder xml)
        {
            xml.Append("<orders>");
            foreach (var order in _orders)
            {
                order.AppendAttributes(xml);
                //xml.Append("<order");
                //xml.Append(" id='");
                //xml.Append(order.Id);
                //xml.Append("' totalPrice='");
                //xml.Append(order.TotalPrice);
                //xml.Append("'>");
                //WriteProductsTo(xml, order);
                //xml.Append("</order>");
            }
            xml.Append("</orders>");
        }
    }
}