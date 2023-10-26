using Microsoft.AspNetCore.Components;

using RandomWorkings.github.io.Components.DTO;

namespace RandomWorkings.github.io.Components.Shared;

partial class TabControl
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    [Parameter]
    public TabColours TabColours { get; set; } = new();

    public TabPage? ActivePage { get; set; }

    public List<TabPage> Pages = new();

    public void AddPage( TabPage tabPage )
    {
        Pages.Add( tabPage );
        if ( Pages.Count == 1 )
            ActivePage = tabPage;
        StateHasChanged();
    }

    string GetTabColour( TabPage page )
    {
        return page == ActivePage ? TabColours.TabActive : TabColours.TabInactive;
    }

    public void ActivatePage( TabPage page )
    {
        ActivePage = page;
    }
}