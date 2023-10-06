namespace RandomWorkings.github.io.Components;

partial class SideBar
{
    private bool _collapseNavMenu = true;
    
    private void ToggleNavMenu()
    {
        _collapseNavMenu = !_collapseNavMenu;
    }

    private string? NavMenuCssClass => _collapseNavMenu ? "collapse" : null;
}
