using Godot;
using System;

public partial class structure_create : Node2D
{
	[Export]
	public Button ani, dirt, water, rec;
	[Export]
	public PackedScene aniScene, dirtScene, waterScene, recScene;
	public void _on_button_pressed(Button button)
	{
		if (button == ani)
		{
			var aa = aniScene.Instantiate<Node2D>();
			aa.Position = new Vector2(0, 0);
			AddChild(aa);
		}
		else if (button == dirt)
		{
			var aa = dirtScene.Instantiate<Node2D>();
			aa.Position = new Vector2(0, 0);
			AddChild(aa);
		}
		else if (button == water)
		{
			var aa = waterScene.Instantiate<Node2D>();
			aa.Position = new Vector2(0, 0);
			AddChild(aa);
		}
		else if (button == rec)
		{
			var aa = recScene.Instantiate<Node2D>();
			aa.Position = new Vector2(0, 0);
			AddChild(aa);
		}
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
