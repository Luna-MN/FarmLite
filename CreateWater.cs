using Godot;
using System;

public partial class CreateWater : Area2D
{
	[Export] CollisionObject2D MyCollider;

	public override void _Ready()
	{

		MyCollider.InputEvent += MyInputMethod;

	}

	void MyInputMethod(Node viewport, InputEvent @event, long shapeIdx)
	{

		if (@event is InputEventMouseButton mousButt)
		{

			if (mousButt.Pressed)
			{

				GD.Print("woooo");
			}

		}

	}
}
