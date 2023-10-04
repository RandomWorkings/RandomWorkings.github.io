namespace RandomWorkings.github.io.Model;

public class ButtonModel : ModelBase
{
    public string Text { get; set; } = string.Empty;
    public LinkModel Link { get; set; } = new();
    public ImageModel Image { get; set; } = new();

    public Dictionary<string, object> ButtonAttributes { get => GenerateAttributes(); }

    public Dictionary<string, object> TextZoneAttributes { get => GenerateTextZoneAttributes(); }

    public Dictionary<string, object> ImageZoneAttributes { get => GenerateImageZoneAttributes(); }

    public override Dictionary<string, object> GenerateAttributes( )
    {
        var attributes = new Dictionary<string, object>
        {
            { "id", $"{Id}-button" },
            { "class", $"btn m-2 button {Classes}" }
        };

        return attributes;
    }
    private Dictionary<string, object> GenerateImageZoneAttributes()
    {
        var attributes = new Dictionary<string, object>
        {
            { "id", $"{Id}-button-image" },
            { "class", "col-auto button-image" }
        };

        return attributes;
    }

    private Dictionary<string, object> GenerateTextZoneAttributes()
    {
        var attributes = new Dictionary<string, object>
        {
            { "id", $"{Id}-button-text" },
            { "class", "col ps-0 button-text" }
        };

        return attributes;
    }
}