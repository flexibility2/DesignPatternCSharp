using System.Xml;

namespace P02_Factory.Step1_Simple;

public class XmlRuleConfigParser : IRuleConfigParser
{
    public RuleConfig Parse(string configText)
    {
        try
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(configText);

            XmlNode databaseNode = xmlDoc.SelectSingleNode("//database");
            if (databaseNode == null)
            {
                throw new ArgumentException("Invalid XML format: database node not found.");
            }

            string ip = GetNodeText(databaseNode, "ip");
            int port = int.Parse(GetNodeText(databaseNode, "port"));
            string username = GetNodeText(databaseNode, "username");
            string password = GetNodeText(databaseNode, "password");

            return new RuleConfig()
            {
                Ip = ip,
                Port = port,
                Username = username,
                Password = password
            };
        }
        catch (Exception ex)
        {
            throw new ArgumentException("Error parsing XML config: " + ex.Message, ex);
        }
    }
    
    private string GetNodeText(XmlNode parentNode, string nodeName)
    {
        XmlNode node = parentNode.SelectSingleNode(nodeName);
        return node?.InnerText;
    }
}