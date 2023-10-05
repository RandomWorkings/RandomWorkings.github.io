using Microsoft.AspNetCore.Components;

using RandomWorkings.github.io.Model;

namespace RandomWorkings.github.io.Components;

partial class MainLayout : LayoutComponentBase
{
    public ButtonModel UpTop { get; set; } = new()
    {
        Id = "jumptotop",
        Text = "Back to Top",
        Image = new()
        {
            Src = "images/icons/common/icon-arrow-up.svg",
            Width = "25px",
            Height = "25px",
            AlternativeText = "An arrow pointing up",
        },
        Link = new()
        {
            Href = "#header",
            TitleAttribute = "Link that jumps you back to top of current page."
        }
    };
}