using Godot;
using System;

public partial class Door : Area2D
{
	[Export]
	public string NextLevel = "";
	
	[Export]
	public string CurrentLevel = "";
	
	private bool hasBeenTriggered = false;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		this.BodyEntered += OnBodyEntered;
	}
	
	 private void OnBodyEntered(Node body)
	{
		GD.Print(body);
		GD.Print(NextLevel);
		if (body is Knight)
		{
			if(!hasBeenTriggered)
			{
				//hasBeenTriggered = true;
				GD.Print("Knight has entered the door.");
				GameManager.Get().GetLevelManager().LoadLevel(NextLevel, CurrentLevel );
			}
			
			
			
		}
		GD.Print(GameManager.Get().GetSaveManager());
	
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
