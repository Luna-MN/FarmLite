using Godot;
using System;

public partial class Seeds : CanvasLayer
{
	bool Corn = false, Carrot = false, Cabbage = false, Parsnip = false, cucumber = false, wheat = false;
	[Export]
	public PackedScene Cornseed, Carrotseed, Cabbageseed, Parsnipseed, Cucumberseed, Wheatseed;
	public Node2D made;

	private void SetSeedStatus(ref bool seed, string seedName)
	{
		seed = true;
		GD.Print(seedName);
	}

	private void ResetSeedStatus(ref bool seed)
	{
		seed = false;
	}

	private void CornEnter()
	{
		SetSeedStatus(ref Corn, "Corn");
	}

	private void CornExit()
	{
		ResetSeedStatus(ref Corn);
	}

	private void CarrotEnter()
	{
		SetSeedStatus(ref Carrot, "Carrot");
	}

	private void CarrotExit()
	{
		ResetSeedStatus(ref Carrot);
	}

	private void CabbageEnter()
	{
		SetSeedStatus(ref Cabbage, "Cabbage");
	}

	private void CabbageExit()
	{
		ResetSeedStatus(ref Cabbage);
	}

	private void ParsnipEnter()
	{
		SetSeedStatus(ref Parsnip, "Parsnip");
	}

	private void ParsnipExit()
	{
		ResetSeedStatus(ref Parsnip);
	}

	private void CucumberEnter()
	{
		SetSeedStatus(ref cucumber, "Cucumber");
	}

	private void CucumberExit()
	{
		ResetSeedStatus(ref cucumber);
	}

	private void WheatEnter()
	{
		SetSeedStatus(ref wheat, "Wheat");
	}

	private void WheatExit()
	{
		ResetSeedStatus(ref wheat);
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
					made.Set("drag", true); // Set the 'drag' property of the 'Node2D' instance
				}
			}
		}
		else if (Carrot)
		{
			if (@event is InputEventMouseButton mouseButton)
			{
				if (mouseButton.ButtonIndex == MouseButton.Left && mouseButton.Pressed)
				{
					GD.Print("Button pressed");
					made = Carrotseed.Instantiate<Carrotseed>();
					made = (Carrotseed)made;
					GetTree().Root.AddChild(made);
					made.Set("drag", true); // Set the 'drag' property of the 'Node2D' instance
				}
			}
		}
		else if (Cabbage)
		{
			if (@event is InputEventMouseButton mouseButton)
			{
				if (mouseButton.ButtonIndex == MouseButton.Left && mouseButton.Pressed)
				{
					GD.Print("Button pressed");
					made = Cabbageseed.Instantiate<Cabbageseed>();
					made = (Cabbageseed)made;
					GetTree().Root.AddChild(made);
					made.Set("drag", true); // Set the 'drag' property of the 'Node2D' instance
				}
			}
		}
		else if (Parsnip)
		{
			if (@event is InputEventMouseButton mouseButton)
			{
				if (mouseButton.ButtonIndex == MouseButton.Left && mouseButton.Pressed)
				{
					GD.Print("Button pressed");
					made = Parsnipseed.Instantiate<Parsnipseeds>();
					made = (Parsnipseeds)made;
					GetTree().Root.AddChild(made);
					made.Set("drag", true); // Set the 'drag' property of the 'Node2D' instance
				}
			}
		}
		else if (cucumber)
		{
			if (@event is InputEventMouseButton mouseButton)
			{
				if (mouseButton.ButtonIndex == MouseButton.Left && mouseButton.Pressed)
				{
					GD.Print("Button pressed");
					made = Cucumberseed.Instantiate<Cucumberseed>();
					made = (Cucumberseed)made;
					GetTree().Root.AddChild(made);
					made.Set("drag", true); // Set the 'drag' property of the 'Node2D' instance
				}
			}
		}
		else if (wheat)
		{
			if (@event is InputEventMouseButton mouseButton)
			{
				if (mouseButton.ButtonIndex == MouseButton.Left && mouseButton.Pressed)
				{
					GD.Print("Button pressed");
					made = Wheatseed.Instantiate<Wheatseed>();
					made = (Wheatseed)made;
					GetTree().Root.AddChild(made);
					made.Set("drag", true); // Set the 'drag' property of the 'Node2D' instance
				}
			}
		}
		// Add similar code blocks for other seed types

		if (@event is InputEventMouseButton mouseButtonn)
		{
			if (mouseButtonn.ButtonIndex == MouseButton.Left && !mouseButtonn.Pressed)
			{
				made.Set("drag", false); // Set the 'drag' property of the 'Node2D' instance
			}
		}
	}
}
