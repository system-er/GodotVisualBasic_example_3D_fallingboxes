
using Godot;
using System;
using vblibrary;

public partial class node3d : Node3D
{
    GodotVisualBasic vbclass;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print("hello world from csharp");
        vbclass = new GodotVisualBasic(this);
        vbclass._Ready();
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        vbclass._Process(delta);
    }
}
