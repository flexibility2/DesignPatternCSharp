namespace P02_Factory.Step1_Simple;

public class RuleConfigSource
{
    public RuleConfig Load(string ruleConfigFilePath)
    {
        string ruleConfigFileExtension = GetFileExtension(ruleConfigFilePath);
        IRuleConfigParser parser = RuleConfigParserFactory.CreateParser(ruleConfigFileExtension);
        if (parser == null)
        {
            throw new Exception(
                $"Rule config file format is not supported: {ruleConfigFilePath}");
        }

        string configText = "";
        // 从ruleConfigFilePath文件中读取配置文本到configText中
        RuleConfig ruleConfig = parser.Parse(configText);
        return ruleConfig;
    }

    private string GetFileExtension(string filePath)
    {
        //...解析文件名获取扩展名，比如rule.json，返回json
        return "json";
    }
}