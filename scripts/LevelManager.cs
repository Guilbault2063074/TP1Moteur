using Godot;
using System;


public partial class LevelManager : Node
{
public Node simultaneousScene;
public Node currentScene;




public void LoadLevel(string sceneName, string currentScene)
	{
		//GD.Print(sceneName);
		simultaneousScene = ResourceLoader.Load<PackedScene>(sceneName).Instantiate();
		//GD.Print(simultaneousScene);
		//GameManager.Get().Root.AddChild(simultaneousScene);
		GameManager.Get().ChangeSceneToFile(sceneName);
		

	}
}
