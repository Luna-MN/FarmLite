using Godot;
using System;
using System.Diagnostics;

public partial class Main : Node2D
{
	private void _on_button_pressed()
	{
		GD.Print("Button pressed");
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

