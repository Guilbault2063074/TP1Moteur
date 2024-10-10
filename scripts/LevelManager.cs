using Godot;
using System;

public partial class LevelManager : Node
{
	public void LoadLevel(String sceneName)
	{
		GD.Print(sceneName);
		GetTree().ChangeSceneToFile("sceneName");
	}
}
