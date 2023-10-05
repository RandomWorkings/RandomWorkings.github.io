﻿using RandomWorkings.github.io.Model;

namespace RandomWorkings.github.io.Pages.Fungrounds;

partial class FunGrounds
{
    public ButtonModel TreasureHunt { get; set; } = new()
    {
        Id= "teasure-hunt",
        Text = "Treasure Hunt",
        Image = new()
        {
            Src = "images/fungrounds/P32Fungrounds_Treasure.svg",
            Width  = "25px",
            Height  = "25px",
            AlternativeText = "A pirates treasure chest.",
        },
        Link = new() 
        {
            Href = "/fungrounds/treasurehunt",
            TitleAttribute = "Link to the P32 Fungrounds treasure hunt rules page."
        }
    };

    public ButtonModel Race { get; set; } = new()
    {
        Id = "race",
        Text = "Race",
        Image = new()
        {
            Src = "images/fungrounds/P32Fungrounds_Race.svg",
            Width = "25px",
            Height = "25px",
            AlternativeText = "A waving checkered race flag.",
        },
        Link = new()
        {
            Href = "/fungrounds/race",
            TitleAttribute = "Link to the P32 Fungrounds race rules page."
        }
    };

    public ButtonModel HideAndSeek { get; set; } = new()
    {
        Id = "hide-and-seek",
        Text = "Hide and Seek",
        Image = new()
        {
            Src = "images/fungrounds/P32Fungrounds_Hide-and-Seek.svg",
            Width = "25px",
            Height = "25px",
            AlternativeText = "Two people playing hide and seek.",
        },
        Link = new()
        {
            Href = "/fungrounds/hideandseek",
            TitleAttribute = "Link to the P32 Fungrounds hide and seek rules page."
        }
    };

    public ButtonModel Zombies { get; set; } = new()
    {
        Id = "zombies",
        Text = "Zombie Mode",
        Image = new()
        {
            Src = "images/fungrounds/P32Fungrounds_Zombie.svg",
            Width = "25px",
            Height = "25px",
            AlternativeText = "Three zombie hands raising out of disturbed earth.",
        },
        Link = new()
        {
            Href = "/fungrounds/zombies",
            TitleAttribute = "Link to the P32 Fungrounds zombies mode information page."
        }
    };

    public ButtonModel Parade { get; set; } = new()
    {
        Id = "parade",
        Text = "Parade",
        Image = new()
        {
            Src = "images/fungrounds/P32Fungrounds_Parade.svg",
            Width = "25px",
            Height = "25px",
            AlternativeText = "A marching band drummer.",
        },
        Link = new()
        {
            Href = "/fungrounds/parade",
            TitleAttribute = "Link to the P32 Fungrounds Parade rules page."
        }
    };

    public ButtonModel Riddles { get; set; } = new()
    {
        Id = "riddles",
        Text = "Riddles",
        Image = new()
        {
            Src = "images/fungrounds/P32Fungrounds_Riddles.svg",
            Width = "25px",
            Height = "25px",
            AlternativeText = "Two speech bubbles. One contains a question mark. The other the three dots of an ellipsis.",
        },
        Link = new()
        {
            Href = "/fungrounds/riddles",
            TitleAttribute = "Link to the P32 Fungrounds Riddles rules page."
        }
    };

    public ButtonModel SharkHunt { get; set; } = new()
    {
        Id = "shark-hunt",
        Text = "Shark Hunt",
        Image = new()
        {
            Src = "images/fungrounds/P32Fungrounds_Shark.svg",
            Width = "25px",
            Height = "25px",
            AlternativeText = "A Shark.",
        },
        Link = new()
        {
            Href = "/fungrounds/sharkhunt",
            TitleAttribute = "Link to the P32 Shark Hunt rules page."
        }
    };


    public ButtonModel Crossbows { get; set; } = new()
    {
        Id = "crossbows",
        Text = "Crossbows",
        Image = new()
        {
            Src = "images/fungrounds/P32Fungrounds_Crossbow.svg",
            Width = "25px",
            Height = "25px",
            AlternativeText = "An crossbow.",
        },
        Link = new()
        {
            Href = "/fungrounds/crossbows",
            TitleAttribute = "Link to the Crossbow Mode information page."
        }
    };

    public ButtonModel WeaponVariants { get; set; } = new()
    {
        Id = "weapon-variants",
        Text = "Weapon Variants",
        Image = new()
        {
            Src = "images/fungrounds/P32Fungrounds_Rifle.svg",
            Width = "25px",
            Height = "25px",
            AlternativeText = "An AKM looking rifle.",
        },
        Link = new()
        {
            Href = "/fungrounds/weapon-variants",
            TitleAttribute = "Link to the Weapon Variant mode information page."
        }
    };
}