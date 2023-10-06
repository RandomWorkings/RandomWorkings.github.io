namespace RandomWorkings.github.io.Model;

public class ImageModel : ModelBase
{
    public string Src { get; set; } = string.Empty;
    public string Width { get; set; } = "100%";
    public string Height { get; set; } = "100%";
    public string AlternativeText { get; set; } = "Unhelpful Alternative Text for an Image";
    public string LanguageAttribute { get; set; } = "en-gb";
    public string LazyLoading { get; set; } = "lazy";

    public override Dictionary<string, object> GenerateAttributes()
    {
        var attributes = new Dictionary<string, object>
        {
            { "class", $"image {Classes}" },
            { "src", Src },
            { "width", Width },
            { "height", Height },
            { "alt",  AlternativeText },
            { "lang",  LanguageAttribute },
            { "loading", LazyLoading },
        };

        return attributes;
    }
}