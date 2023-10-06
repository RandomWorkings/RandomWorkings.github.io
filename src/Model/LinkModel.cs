namespace RandomWorkings.github.io.Model;

public class LinkModel : ModelBase
{
    public string Href { get; set; } = "/";
    public string Target { get; set; } = "_self";
    public string TitleAttribute { get; set; } = "Hyperlink to Home";
    public string LanguageAttribute { get; set; } = "en-gb";  

    public override Dictionary<string, object> GenerateAttributes( )
    {
        var attributes = new Dictionary<string, object>
        {
            { "class", $"link {Classes}" },
            { "href", Href },
            { "target", Target },
            { "title", TitleAttribute },
            { "lang", LanguageAttribute },
        };

        return attributes;
    }
}