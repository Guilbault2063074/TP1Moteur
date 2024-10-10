using Godot;
using System;

public partial class SaveManager : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	public void SaveGame(string _filePath){
		var saveNodes = GetTree().GetNodesInGroup("Persist");
	}
	
	public void LoadGame(string _filePath){
		//Call Level manager to load the level and player coordinates
	}
}
