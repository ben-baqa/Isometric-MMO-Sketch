using Godot;
using System;
using System.Collections.Generic;

public class DefineSyntaxHighlighting : TextEdit
{
    [Export]
    public List<string> keywords = new List<string>();
    [Export]
    public Color col;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        foreach(string s in keywords)
            AddKeywordColor(s, col);

        AddColorRegion("/", " ", col, false);
    }
}
