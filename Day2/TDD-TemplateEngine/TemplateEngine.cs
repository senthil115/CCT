
namespace TemplateEngine;

public class TemplateEngine
{
    string template;
    Dictionary<string, string> map;

    public TemplateEngine(){
        this.template = "";
        this.map = new Dictionary<string, string>();
    }
    public string Evaluate()
    {
        string result = template;
        foreach (var entry in map)
        {
            result = result.Replace("{" + entry.Key + "}", entry.Value);
        }
        return result;
    }

    public void SetTemplate(string template)
    {
        this.map.Clear();
        this.template = template;
    }

    public void SetVariable(string name, string value)
    {
        map.Add(name, value);
    }
}
