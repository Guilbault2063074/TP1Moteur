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
			
			GD.Print("return gamemanager");
			return instance;
	}
		
	public override void _Initialize()
	{
		//GD.Print("GameManager Initialized:");
		//GD.Print($"  Starting Time: {_timeElapsed}");
		
		instance = this;
		
		_levelManager = new LevelManager();
		_saveManager = new SaveManager();
		
		Ready();
	}
	
	public void Ready()
	{
		//GD.Print("GameManager Ready");
		//_levelManager.LoadLevel("res://scene/Levels/Level1.tscn");
		Root.AddChild(_levelManager);
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
