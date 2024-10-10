using Godot;
using System;

public partial class LevelManager : Node
{
	public void LoadLevel(String sceneName)
	{
		var nextScene = (PackedScene)ResourceLoader.Load(sceneName);
		if(nextScene !=null)
		{
			GetTree().ChangeSceneToPacked(nextScene);
		}
		else
		{
			GD.Print($"Failed to load scene: {sceneName}");
		}
	}
}
