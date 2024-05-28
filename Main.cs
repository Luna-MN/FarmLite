using Godot;
using System;
using System.Diagnostics;

public partial class Main : Node2D
{
	[Export]
	public PackedScene fenceScene;

	public void _on_button_pressed(Node2D tile)
	{
		GD.Print("Button pressed");
		var aa = fenceScene.Instantiate<Node2D>();
		GD.Print(aa);
		tile.AddChild(aa);
		aa.Position = new Vector2(0, 0);
		aa.GlobalScale = new Vector2(1, 1);
		GD.Print(aa.Position);

	}

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}
}

