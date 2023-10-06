namespace RandomWorkings.github.io.Model;

public class ButtonModel : ModelBase
{
    public string Text { get; set; } = string.Empty;
    public LinkModel? Link { get; set; } = null;
    public ImageModel? Image { get; set; } = null;

    public Dictionary<string, object> ButtonAttributes { get => GenerateAttributes(); }
    public Dictionary<string, object> LinkAttributes { get => Link != null ? Link.GenerateAttributes() : new(); }
    public Dictionary<string, object> ImageAttributes { get => Image != null ? Image.GenerateAttributes() : new(); }

    public override Dictionary<string, object> GenerateAttributes( )
    {
        var attributes = new Dictionary<string, object>
        {
            { "class", $"btn button {Classes}" }
        };

        return attributes;
    }
}