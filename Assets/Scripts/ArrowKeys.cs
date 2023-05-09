using Godot;
using Godot.Collections;
using System;

public partial class ArrowKeys : AspectRatioContainer
{
	TextureRect upArrow;
	[Export]
	Texture2D[] upArrowSprites;
	TextureRect rightArrow;
	[Export]
	Texture2D[] rightArrowSprites;
	TextureRect downArrow;
	[Export]
	Texture2D[] downArrowSprites;
	TextureRect leftArrow;
	[Export]
	Texture2D[] leftArrowSprites;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		////GD.Print(this.GetChildCount());
		////GD.Print(this.GetChild<TextureRect>(0) == null);
		////GD.Print(ResourceLoader.Load<Texture2D>("res://Assets/Sprites/PurpleArrowOff.svg") == null);
		GD.Print(upArrowSprites == null);

		upArrow = this.GetChild<TextureRect>(0);

		rightArrow = this.GetChild<TextureRect>(1);

		downArrow = this.GetChild<TextureRect>(2);

		leftArrow = this.GetChild<TextureRect>(3);
	}
	

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		upArrow.Texture = upArrowSprites[Input.IsKeyPressed(Key.Up) ? 1 : 0];
		rightArrow.Texture = rightArrowSprites[Input.IsKeyPressed(Key.Right) ? 1 : 0];
		downArrow.Texture = downArrowSprites[Input.IsKeyPressed(Key.Down) ? 1 : 0];
		leftArrow.Texture = leftArrowSprites[Input.IsKeyPressed(Key.Left) ? 1 : 0];
		
	}
}
