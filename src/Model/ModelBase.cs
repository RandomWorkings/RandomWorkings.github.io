namespace RandomWorkings.github.io.Model;

public abstract class ModelBase
{
    public string Id { get; set; } = "element";
    public string Classes { get; set; } = string.Empty;

    public Dictionary<string, object> Attributes { get => GenerateAttributes(); }

    public abstract Dictionary<string, object> GenerateAttributes();
}