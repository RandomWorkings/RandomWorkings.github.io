using Microsoft.AspNetCore.Components;

namespace RandomWorkings.github.io.Components.Shared;

partial class PageHeader
{
    [Parameter]
    public string Text { get; set; } = "Page Header";

    [Parameter]
    public string ImageSource { get; set; } = string.Empty;

}
