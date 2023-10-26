using Microsoft.AspNetCore.Components;

namespace RandomWorkings.github.io.Components.Shared;

partial class TabControl
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    public TabPage? ActivePage { get; set; }

    public List<TabPage> Pages = new();

    public void AddPage( TabPage tabPage )
    {
        Pages.Add( tabPage );
        if ( Pages.Count == 1 )
            ActivePage = tabPage;
        StateHasChanged();
    }

    public void ActivatePage( TabPage page )
    {
        ActivePage = page;
    }
}