using Godot;
using System;

public partial class Seeds : CanvasLayer
{
	bool Corn = false;
	private void CornEnter()
	{
		Corn = true;
	}
	private void CornExit()
	{
		Corn = false;
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
