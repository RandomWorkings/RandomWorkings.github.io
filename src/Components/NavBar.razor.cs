using RandomWorkings.github.io.Model;

namespace RandomWorkings.github.io.Components;

partial class NavBar
{
    public ButtonModel YouTube { get; set; } = new()
    {
        Id = "youtube",
        Text = "YouTube",
        Image = new()
        {
            Src = "images/icons/social-media/brand-youtube.svg",
            Width = "25px",
            Height = "25px",
            AlternativeText = "Youtube Logo",
        },
        Link = new()
        {
            Href = "https://www.youtube.com/channel/UCE_oP0PoaZSFqwWV9Bs0rTA/",
            TitleAttribute = "Link to Youtube"
        }
    };

    public ButtonModel GitHub { get; set; } = new()
    {
        Id = "github",
        Text = "GitHub",
        Image = new()
        {
            Src = "images/icons/social-media/brand-github.svg",
            Width = "25px",
            Height = "25px",
            AlternativeText = "Github Logo",
        },
        Link = new()
        {
            Href = "https://github.com/RandomWorkings/",
            TitleAttribute = "Link to GitHub"
        }
    };

    public ButtonModel ReferencePage { get; set; } = new()
    {
        Id = "linktree",
        Text = "Linktree",
        Image = new()
        {
            Src = "images/icons/social-media/brand-linktree.svg",
            Width = "25px",
            Height = "25px",
            AlternativeText = "Link Tree Logo",
        },
        Link = new()
        {
            Href = "https://linktr.ee/Random_Workings",
            TitleAttribute = "Link to Linktree Reference Page"
        }
    };

}