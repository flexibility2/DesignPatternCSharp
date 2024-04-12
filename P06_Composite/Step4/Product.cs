using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Composite.Step4
{
    public class Product : INode
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public int Quantity { get; set; }

        public const string NotApplicable = "NOT_APPLICABLE";

        public void AppendAttributes(StringBuilder xml)
        {
            xml.Append("<product");
            xml.Append(" id='");
            xml.Append(this.Id);
            xml.Append("'");
            xml.Append(" color='");
            xml.Append(this.Color);
            xml.Append("'");
            if (this.Size != NotApplicable)
            {
                xml.Append(" size='");
                xml.Append(this.Size);
                xml.Append("'");
            }
            xml.Append(">");
            WritePriceTo(xml);
            xml.Append(this.Name);
            xml.Append("</product>");
        }

        private void WritePriceTo(StringBuilder xml)
        {
            xml.Append("<price");
            xml.Append(" currency='");
            xml.Append(Currency);
            xml.Append("'>");
            xml.Append(Price);
            xml.Append("</price>");
        }
    }
}