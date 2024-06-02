using Godot;
using System;

public partial class UI : CanvasLayer
{
	[Export] CollisionObject2D MyCollider;
	[Export] TileMap tileMap;
	bool enter = false, enterA = false, openP = true, openA = true;
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
						tileMap.SetLayerEnabled(1, false);
						tileMap.SetLayerEnabled(2, false);
						openP = false;
					}
					else if (!openP)
					{
						tileMap.SetLayerEnabled(1, true);
						tileMap.SetLayerEnabled(2, true);
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
						tileMap.SetLayerEnabled(5, false);
						tileMap.SetLayerEnabled(6, false);
						openA = false;
					}
					else if (!openA)
					{
						tileMap.SetLayerEnabled(5, true);
						tileMap.SetLayerEnabled(6, true);
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
