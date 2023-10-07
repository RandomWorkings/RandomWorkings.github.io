using Microsoft.AspNetCore.Components;

namespace RandomWorkings.github.io.Components.Shared;

partial class ImageButton : Button
{
    [Parameter]
    public string Src { get; set; } = string.Empty;

    [Parameter] 
    public string Width { get; set; } = "100%";

    [Parameter]
    public string Height { get; set; } = "100%";

    [Parameter]
    public string AlternativeText { get; set; } = "Unhelpful Alternative Text for an Image";

    [Parameter]
    public string LazyLoading { get; set; } = "lazy";
    
    public Dictionary<string, object> ImageAttributes { get => GenerateImageAttributes(); }

    public Dictionary<string, object> GenerateImageAttributes()
    {
        var attributes = new Dictionary<string, object>
        {
            { "class", $"image {Classes}" },
            { "src", Src },
            { "width", Width },
            { "height", Height },
            { "alt",  AlternativeText },
            { "loading", LazyLoading },
        };

        return attributes;
    }
}