using Godot;
using System;

public partial class Seeds : CanvasLayer
{
	bool Corn = false;
	[Export]
	public PackedScene Cornseed;
	Cornseed made;

	private void CornEnter()
	{
		Corn = true;
		GD.Print("Corn");
	}
	private void CornExit()
	{
		Corn = false;
	}
	private void CarrotEnter()
	{


	}
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}
	public override void _Input(InputEvent @event)
	{
		base._Input(@event);
		if (Corn)
		{
			if (@event is InputEventMouseButton mouseButton)
			{
				if (mouseButton.ButtonIndex == MouseButton.Left && mouseButton.Pressed)
				{
					GD.Print("Button pressed");
					made = Cornseed.Instantiate<Cornseed>();
					GetTree().Root.AddChild(made);
					made.drag = true;
				}
			}
		}

		if (@event is InputEventMouseButton mouseButtonn)
		{
			if (mouseButtonn.ButtonIndex == MouseButton.Left && !mouseButtonn.Pressed)
			{
				made.drag = false;
			}
		}

	}

}