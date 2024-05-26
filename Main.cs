using Godot;
using System;

public partial class Main : Node2D
{

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
        if (Input.IsActionJustPressed("click"))
        {
            Vector2 mousePos = GetGlobalMousePosition();
			var query = new PhysicsPointQueryParameters2D();
			query.Position = mousePos;
            Godot.Collections.Array<Godot.Collections.Dictionary> result = GetWorld2D().DirectSpaceState.IntersectPoint(query);

            if (result.Count > 0)
            {
                Node clickedNode = (Node)result[0]["collider"];
                GD.Print("Mouse clicked on: " + clickedNode.Name);
            }
        }
	}
}
