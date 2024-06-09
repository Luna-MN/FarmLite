using Godot;
using System;

public partial class Parsnipseeds : Node2D
{
	public bool drag = true;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (drag)
		{
			Position = GetGlobalMousePosition();
		}
		if (!drag)
		{
			QueueFree();
		}
	}
}
