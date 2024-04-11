namespace P02_Factory.Step1_Simple;

public class RuleConfigParserFactory
{
    public static IRuleConfigParser CreateParser(string configFormat)
    {
        IRuleConfigParser parser = null;
        if ("json".Equals(configFormat, StringComparison.OrdinalIgnoreCase))
        {
            parser = new JsonRuleConfigParser();
        }
        else if ("xml".Equals(configFormat, StringComparison.OrdinalIgnoreCase))
        {
            parser = new XmlRuleConfigParser();
        }
        else if ("yaml".Equals(configFormat, StringComparison.OrdinalIgnoreCase))
        {
            parser = new YamlRuleConfigParser();
        }

        return parser;
    }
}





