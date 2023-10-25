using Microsoft.AspNetCore.Components;

namespace RandomWorkings.github.io.Components.Shared;

partial class TabPage
{
    [CascadingParameter]
    private TabControl? Parent { get; set; }

    [Parameter]
    public string TabLabel { get; set; } = "Tab";


    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    protected override void OnInitialized()
    {
        if ( Parent == null )
            throw new ArgumentNullException( nameof( Parent ), "TabPage must exist within a TabControl" );
        base.OnInitialized();
        Parent.AddPage( this );
    }
}