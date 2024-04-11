using YamlDotNet.Serialization;

namespace P02_Factory.Step1_Simple;

public class YamlRuleConfigParser : IRuleConfigParser
{
    public RuleConfig Parse(string configText)
    {
        try
        {
            var deserializer = new Deserializer();
            dynamic yamlObject = deserializer.Deserialize(new StringReader(configText));

            if (yamlObject == null || !yamlObject.ContainsKey("database"))
            {
                throw new ArgumentException("Invalid YAML format: database section not found.");
            }

            dynamic databaseObject = yamlObject["database"];

            string ip = databaseObject["ip"];
            int port = databaseObject["port"];
            string username = databaseObject["username"];
            string password = databaseObject["password"];

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
            throw new ArgumentException("Error parsing YAML config: " + ex.Message, ex);
        }
    }
}