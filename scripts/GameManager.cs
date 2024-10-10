using Godot;
using System;

[GlobalClass]
public partial class GameManager : SceneTree
{
	private static GameManager instance;
	
	private LevelManager levelManager;
	private SaveManager saveManager;
	private double _timeElapsed;
	
	public static GameManager Get()
	{
			if (instance == null)
			{
				instance = new GameManager();
				GD.Print("GameManager instance created");
				instance._Initialize();
			}
			GD.Print("return gamemanager");
			return instance;
	}
		
	public override void _Initialize()
	{
		GD.Print("GameManager Initialized:");
		GD.Print($"  Starting Time: {_timeElapsed}");
	}
		
	public override bool _Process(double delta)
	{
		_timeElapsed += delta;
		
		if (Input.IsActionPressed("ui_cancel")) //
		{
			GD.Print("Escape pressed, handle exit logic");
			return true;
		}
		
		return false;
	}
		
	
}
