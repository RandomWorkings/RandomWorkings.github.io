using Microsoft.AspNetCore.Components;

using RandomWorkings.github.io.Model;

namespace RandomWorkings.github.io.Components;

partial class Button : ComponentBase
{
    [Parameter]
    public ButtonModel ButtonModel { get; set; } = new();

}