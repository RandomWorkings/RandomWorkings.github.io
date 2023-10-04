using RandomWorkings.github.io.Model;

namespace RandomWorkings.github.io.Pages.Fungrounds;

partial class FunGrounds
{
    public ButtonModel TreasureHunt { get; set; } = new()
    {
        Id= "teasure-hunt",
        Text = "Treasure Hunt",
        Image = new()
        {
            Id = "teasure-hunt",
            Src = "images/fungrounds/P32Fungrounds_Treasure.svg",
            Width  = "25px",
            Height  = "25px",
            AlternativeText = "A pirates treasure chest",
        },
        Link = new() 
        {
            Id = "teasure-hunt",
            Href = "/fungrounds/treasurehunt",
            TitleAttribute = "Link to P32 Fungrounds treasure hunt information page"
        }
    };

    public ButtonModel Race { get; set; } = new()
    {
        Id = "race",
        Text = "Race",
        Image = new()
        {
            Id = "race",
            Src = "images/fungrounds/P32Fungrounds_Race.svg",
            Width = "25px",
            Height = "25px",
            AlternativeText = "A waving checkered race flag",
        },
        Link = new()
        {
            Id = "race",
            Href = "/fungrounds/race",
            TitleAttribute = "Link to P32 Fungrounds race information page"
        }
    };

    public ButtonModel HideAndSeek { get; set; } = new()
    {
        Id = "hide-and-seek",
        Text = "Hide and Seek",
        Image = new()
        {
            Id = "hide-and-seek",
            Src = "images/fungrounds/P32Fungrounds_Hide-and-Seek.svg",
            Width = "25px",
            Height = "25px",
            AlternativeText = "Two people playing hide and seek",
        },
        Link = new()
        {
            Id = "hide-and-seek",
            Href = "/fungrounds/hideandseek",
            TitleAttribute = "Link to P32 Fungrounds hide and seek information page"
        }
    };

    public ButtonModel Zombies { get; set; } = new()
    {
        Id = "zombies",
        Text = "Zombie Mode",
        Image = new()
        {
            Id = "zombies",
            Src = "images/fungrounds/P32Fungrounds_Zombie.svg",
            Width = "25px",
            Height = "25px",
            AlternativeText = "Three zombie hands raising out of disturbed earth",
        },
        Link = new()
        {
            Id = "zombies",
            Href = "/fungrounds/zombies",
            TitleAttribute = "Link to P32 Fungrounds zombies mode information page"
        }
    };

    public ButtonModel Parade { get; set; } = new()
    {
        Id = "parade",
        Text = "Parade",
        Image = new()
        {
            Id = "parade",
            Src = "images/fungrounds/P32Fungrounds_Parade.svg",
            Width = "25px",
            Height = "25px",
            AlternativeText = "A marching band drummer",
        },
        Link = new()
        {
            Id = "parade",
            Href = "/fungrounds/parade",
            TitleAttribute = "Link to P32 Fungrounds Parade information page"
        }
    };

    public ButtonModel Riddles { get; set; } = new()
    {
        Id = "riddles",
        Text = "Riddles",
        Image = new()
        {
            Id = "riddles",
            Src = "images/fungrounds/P32Fungrounds_Riddles.svg",
            Width = "25px",
            Height = "25px",
            AlternativeText = "Two speech bubbles. One contains a question mark. The other the three dots of an ellipsis.",
        },
        Link = new()
        {
            Id = "riddles",
            Href = "/fungrounds/riddles",
            TitleAttribute = "Link to P32 Fungrounds Riddles information page"
        }
    };

}