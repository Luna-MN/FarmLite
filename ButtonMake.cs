using Godot;
using System;
using System.Collections;

public partial class ButtonMake : Button
{
	[Export]
	public structure_create SC;
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
		SC._on_button_pressed(this);
		QueueFree();
	}
}
