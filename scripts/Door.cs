using Godot;
using System;

public partial class Door : Area2D
{
	[Export]
	public string NextLevel = "res://scene/Levels/Level2.tscn";
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		this.BodyEntered += OnBodyEntered;
	}
	
	 private void OnBodyEntered(Node body)
	{
		
		if (body is Knight)
		{
			GD.Print("Knight has entered the door.");
			
			
			GameManager.Get().GetLevelManager().LoadLevel(NextLevel);
		}
	}
	
	public override void _ExitTree()
	{
		this.BodyEntered -= OnBodyEntered;
	}
	
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
