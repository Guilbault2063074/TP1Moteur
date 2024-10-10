using Godot;
using System;

[GlobalClass]
public partial class GameManager : SceneTree
{
	private static GameManager instance;
	
	private LevelManager _levelManager;
	private SaveManager _saveManager;
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
		
		_levelManager = new LevelManager();
		_saveManager = new SaveManager();
	}
	
	public void _Ready()
	{
		GD.Print("GameManager Ready");
		_levelManager.LoadLevel("res://scene/Levels/Level1.tscn");
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
	
	public LevelManager GetLevelManager()
	{
		return _levelManager;
	}
		
	public SaveManager GetSaveManager()
	{
		return _saveManager;
	}
	
}
