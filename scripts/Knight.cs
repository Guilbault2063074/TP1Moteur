using Godot;
using System;

public partial class Knight : CharacterBody2D
{
	 private Vector2 direction = Vector2.Zero;
	[Export] private AnimatedSprite2D animatedSprite2D;

	public override void _Ready()
	{
		// Ensure you have the correct path to the AnimatedSprite2D node
		animatedSprite2D = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	}

	public override void _PhysicsProcess(double delta)
	{
		ReadInput();
		MoveAndSlide();
	}

	private void ReadInput()
	{
		Vector2 inputVelocity = Vector2.Zero;

		if (Input.IsActionPressed("Up"))
		{
			inputVelocity.Y-= 1;
			direction = Vector2.Up; // Updated to use Vector2 constants
			animatedSprite2D.Play("run");
		}

		if (Input.IsActionPressed("Down"))
		{
			inputVelocity.Y += 1;
			direction = Vector2.Down; // Updated to use Vector2 constants
			animatedSprite2D.Play("run");
		}

		if (Input.IsActionPressed("Right"))
		{
			inputVelocity.X += 1;
			direction = Vector2.Right; // Updated to use Vector2 constants
			animatedSprite2D.FlipH = false;
			animatedSprite2D.Play("run");
		}

		if (Input.IsActionPressed("Left"))
		{
			inputVelocity.X -= 1;
			direction = Vector2.Left; // Updated to use Vector2 constants
			animatedSprite2D.FlipH = true;
			animatedSprite2D.Play("run");
		}

		if (inputVelocity == Vector2.Zero)
		{
			animatedSprite2D.Play("idle");
		}

		inputVelocity = inputVelocity.Normalized();
		Velocity = inputVelocity * 200; // Use the built-in velocity
	}
}
