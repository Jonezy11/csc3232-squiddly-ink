using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySM : StateMachine
{
	public Idle idleState;
	public Melee meleeState;
	public Ranged rangedState;

	public Sprite idleSprite;
	public Sprite meleeSprite;
	public Sprite rangedSprite;

	// Enemy components
	public BoxCollider2D col;
	public Rigidbody2D rb;
	public SpriteRenderer sr;

	public Collider2D boundary;

	public Collider2D player;

	public float speed;

	public bool playerInRange = false;

	// Persistent facing variable for transitioning between moving states
	public int facing = 1;

	private void Awake()
	{
		// Instantiate states
		idleState = new Idle(this);
		meleeState = new Melee(this);
		rangedState = new Ranged(this);
	}

	protected override BaseState GetInitialState()
	{
		// Begin idle
		return idleState;
	}
}
