using System.Text.Json;

namespace P02_Factory.Step1_Simple;

public class JsonRuleConfigParser : IRuleConfigParser
{
    public RuleConfig Parse(string configText)
    {
        try
        {
            var ruleConfig = JsonSerializer.Deserialize<RuleConfig>(configText);
            return ruleConfig;
        }
        catch (Exception ex)
        {
            throw new ArgumentException("Error parsing JSON config: " + ex.Message, ex);
        }
    }
}