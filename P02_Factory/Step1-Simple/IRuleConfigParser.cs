namespace P02_Factory.Step1_Simple;

public interface IRuleConfigParser
{
    RuleConfig Parse(string configText);
}