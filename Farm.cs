using Godot;
using System;

public partial class Farm : Node2D
{
	public bool seed = false, water = false, drag = false;
	[Export]
	public PackedScene seedplanted;
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
			if (seed)
			{
				Node2D made = seedplanted.Instantiate<Node2D>();
				GetParent().AddChild(made);
				made.Position = GetGlobalMousePosition();
			}
		}
		if (!drag)
		{

		}
	}
}
