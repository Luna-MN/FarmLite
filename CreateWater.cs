using Godot;
using System;

public partial class CreateWater : Node2D
{
	[Export] CollisionObject2D MyCollider;
	bool enter = false;

	public override void _Ready()
	{
	}



	private void CreateWaterPress()
	{
		enter = true;
	}
	public override void _Input(InputEvent @event)
	{
		base._Input(@event);
		if (enter)
		{
			if (@event is InputEventMouseButton mouseButton)
			{
				if (mouseButton.ButtonIndex == MouseButton.Left)
				{

					GD.Print("Button pressed");
				}
			}
		}
	}
}
