using Godot;
using System;

public partial class Seeds : CanvasLayer
{
	bool Corn = false, Carrot = false, Cabbage = false, Parsnip = false, cucumber = false, wheat = false;
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
		Carrot = true;
		GD.Print("Carrot");
	}
	private void CarrotExit()
	{
		Carrot = false;
	}
	private void CabbageEnter()
	{
		Cabbage = true;
		GD.Print("Cabbage");
	}
	private void CabbageExit()
	{
		Cabbage = false;
	}
	private void ParsnipEnter()
	{
		Parsnip = true;
		GD.Print("Parsnip");
	}
	private void ParsnipExit()
	{
		Parsnip = false;
	}
	private void CucumberEnter()
	{
		cucumber = true;
		GD.Print("Cucumber");
	}
	private void CucumberExit()
	{
		cucumber = false;
	}
	private void WheatEnter()
	{
		wheat = true;
		GD.Print("Wheat");
	}
	private void WheatExit()
	{
		wheat = false;
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
		DragCreate(@event);

	}

	private void DragCreate(InputEvent @event)
	{
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
