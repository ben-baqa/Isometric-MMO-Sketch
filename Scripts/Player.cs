using Godot;
using System;

public class Player : RigidBody2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    [Export]
    public float moveSpeed = 1;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

 // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        Vector2 v = new Vector2(0, 0);
        if(Input.IsKeyPressed((int)Godot.KeyList.W))
            v.y -= moveSpeed;
        if(Input.IsKeyPressed((int)Godot.KeyList.S))
            v.y += moveSpeed;
        if(Input.IsKeyPressed((int)Godot.KeyList.A))
            v.x -= moveSpeed;
        if(Input.IsKeyPressed((int)Godot.KeyList.D))
            v.x += moveSpeed;

        LinearVelocity = v;
    }

    private float clamp(float inp, float bot, float top){
        if(bot > top)
            return clamp(inp, top, bot);
        if(inp < bot)
            return bot;
        if(inp > top)
            return top;
        return inp;
    }
}
