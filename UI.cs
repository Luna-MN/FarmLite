using Godot;
using System;

public partial class UI : CanvasLayer
{
	[Export]
	CollisionObject2D MyCollider;
	[Export]
	TileMap tileMap;
	[Export]
	PackedScene Seeds, animals;
	bool enter = false, enterA = false, openP = false, openA = false;
	CanvasLayer seedI, animalI;
	waterDrag made;
	private void CreateWaterPress()
	{
		enter = true;
	}
	private void CreateWaterRelease()
	{
		enter = false;
	}
	private void animalPress()
	{
		enterA = true;
	}
	private void animalRelease()
	{
		enterA = false;
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
		if (enter)
		{
			if (@event is InputEventMouseButton mouseButton)
			{
				if (mouseButton.ButtonIndex == MouseButton.Left && mouseButton.Pressed)
				{
					tileMap.SetLayerEnabled(3, false);
					if (openP)
					{
						seedI.QueueFree();
						openP = false;
					}
					else if (!openP)
					{
						seedI = Seeds.Instantiate<CanvasLayer>();
						AddChild(seedI);
						openP = true;
					}


					GD.Print(openP);
				}
			}
		}
		if (enterA)
		{
			if (@event is InputEventMouseButton mouseButton)
			{
				if (mouseButton.ButtonIndex == MouseButton.Left && mouseButton.Pressed)
				{
					tileMap.SetLayerEnabled(4, false);
					if (openA)
					{
						animalI.QueueFree();
						openA = false;
					}
					else if (!openA)
					{
						animalI = animals.Instantiate<CanvasLayer>();
						AddChild(animalI);
						openA = true;
					}


					GD.Print(openA);
				}
			}
		}

		if (@event is InputEventMouseButton mouseButtonn)
		{
			if (mouseButtonn.ButtonIndex == MouseButton.Left && !mouseButtonn.Pressed)
			{
				tileMap.SetLayerEnabled(3, true);
				tileMap.SetLayerEnabled(4, true);
			}
		}

	}
}
