using Godot;
using System;

public partial class b : Button
{
	[Export]
	public Node2D tile;
	[Export]
	public Main main;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	public override void _Pressed()
	{
		base._Pressed();
		main._on_button_pressed(tile);
		QueueFree();

	}
}
