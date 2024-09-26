extends CharacterBody2D

var direction : Vector2 = Vector2()
@onready var animated_sprite_2d: AnimatedSprite2D = $AnimatedSprite2D

func read_input():
	var input_velocity = Vector2()
	
	if Input.is_action_pressed("Up"):
		input_velocity.y -= 1
		direction = Vector2(0, -1)
		animated_sprite_2d.play("run")
		
	if Input.is_action_pressed("Down"):
		input_velocity.y += 1
		direction = Vector2(0, 1)
		animated_sprite_2d.play("run")
		
	if Input.is_action_pressed("Right"):
		input_velocity.x += 1
		direction = Vector2(1, 0)
		animated_sprite_2d.flip_h = false
		animated_sprite_2d.play("run")
		
	if Input.is_action_pressed("Left"):
		input_velocity.x -= 1
		direction = Vector2(-1, 0)    
		animated_sprite_2d.flip_h = true
		animated_sprite_2d.play("run")

	if input_velocity.x ==0 && input_velocity.y ==0:
		animated_sprite_2d.play("idle")
		
	input_velocity = input_velocity.normalized()
		
	velocity = input_velocity * 200  # Use the built-in velocity

func _physics_process(delta):
	read_input()
	move_and_slide()  # Call the built-in movement method
