using Microsoft.AspNetCore.Components;

namespace RandomWorkings.github.io.Components.Shared;

public abstract class Component : ComponentBase
{
    [Parameter]
    public string Id { get; set; } = string.Empty;

    [Parameter]
    public string Classes { get; set; } = string.Empty;

}