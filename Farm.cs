using Godot;
using System;

public partial class Farm : Node2D
{
	public bool seed = false, water = false, drag = false;
	private void mouseEnter()
	{
		drag = true;
	}
	private void mouseExit()
	{
		drag = false;
	}
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
