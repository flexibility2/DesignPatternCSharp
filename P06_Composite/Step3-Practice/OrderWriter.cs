using System.Text;

namespace P06_Composite.Step3_Practice;

public class OrderWriter
{
    private List<Order> _orders;

    public OrderWriter(List<Order> orders)
    {
        _orders = orders;
    }
    
    public String GetContents() {
        StringBuilder xml = new StringBuilder();
        WriteOrdersTo(xml);
        return xml.ToString();
    }
    
    private void WriteOrdersTo(StringBuilder xml) {
        xml.Append("<orders>");
        foreach (var order in _orders)
        {
            xml.Append("<order");
            xml.Append(" id='");
            xml.Append(order.Id);
            xml.Append("' totalPrice='");
            xml.Append(order.TotalPrice);
            xml.Append("'>");
            WriteProductsTo(xml, order);
            xml.Append("</order>");
        }
        xml.Append("</orders>");
    }
    
    private void WriteProductsTo(StringBuilder xml, Order order)
    {
        foreach (var product in order.Products)
        {
            xml.Append("<product");
            xml.Append(" id='");
            xml.Append(product.Id);
            xml.Append("'");
            xml.Append(" color='");
            xml.Append(product.Color);
            xml.Append("'");
            if (product.Size != Product.NotApplicable)
            {
                xml.Append(" size='");
                xml.Append(product.Size);
                xml.Append("'");
            }
            xml.Append(">");
            WritePriceTo(xml, product);
            xml.Append(product.Name);
            xml.Append("</product>");
        }
    }
    
    private void WritePriceTo(StringBuilder xml, Product product)
    {
        xml.Append("<price");
        xml.Append(" currency='");
        xml.Append(product.Currency);
        xml.Append("'>");
        xml.Append(product.Price);
        xml.Append("</price>");
    }
}