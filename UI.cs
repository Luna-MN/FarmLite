using Godot;
using System;

public partial class UI : CanvasLayer
{
	[Export] CollisionObject2D MyCollider;
	[Export] TileMap tileMap;
	bool enter = false;
	waterDrag made;
	private void CreateWaterPress()
	{
		enter = true;
	}
	private void CreateWaterRelease()
	{
		enter = false;
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
					tileMap.SetLayerEnabled(2, false);
				}
			}
		}

		if (@event is InputEventMouseButton mouseButtonn)
		{
			if (mouseButtonn.ButtonIndex == MouseButton.Left && !mouseButtonn.Pressed)
			{
				tileMap.SetLayerEnabled(2, true);
			}
		}

	}
}
