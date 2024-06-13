using Godot;
using System;

public partial class Farm : Node2D
{
	public bool seed = false, water = false, drag = false;
	[Export]
	public PackedScene plantedcarrot, plantedcorn, plantedcabbage, plantedparsnip, plantedcucumber, plantedwheat;
	public PackedScene seedplanted;
	public enum SeedType
	{
		Corn,
		Carrot,
		Cabbage,
		Parsnip,
		Cucumber,
		Wheat
	}
	public SeedType seedType;
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
				switch (seedType)
				{
					case SeedType.Corn:
						seedplanted = plantedcorn;
						break;
					case SeedType.Carrot:
						seedplanted = plantedcarrot;
						break;
					case SeedType.Cabbage:
						seedplanted = plantedcabbage;
						break;
					case SeedType.Parsnip:
						seedplanted = plantedparsnip;
						break;
					case SeedType.Cucumber:
						seedplanted = plantedcucumber;
						break;
					case SeedType.Wheat:
						seedplanted = plantedwheat;
						break;
					default:
						seedplanted = null;
						break;
				}
			}
		}
		if (!drag)
		{
			if (seed)
			{
				Node2D made = seedplanted.Instantiate<Node2D>();
				GetParent().AddChild(made);
				made.Position = GetGlobalMousePosition();
			}
		}
	}
}
