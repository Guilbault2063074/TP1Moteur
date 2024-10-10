using Godot;
using System;

public partial class Root : Node2D
{


	public override void _Ready()
	{
		base._Ready();
		
		//_levelManager = GameManager.Get().GetLevelManager();
		AddChild(GameManager.Get().GetLevelManager());
		AddChild(GameManager.Get().GetSaveManager());
	}
}
