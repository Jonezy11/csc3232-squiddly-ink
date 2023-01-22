using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : BaseState
{
	protected EnemySM sm;

	private int moveDirection = 1;

	// Base class for states that move, HSM
	public Moving(string name, EnemySM stateMachine) : base(name, stateMachine)
	{
		sm = (EnemySM)this.stateMachine;
	}

	// Retain direction between states
	public override void Enter()
	{
		base.Enter();
		moveDirection = sm.facing;
	}

	public override void Exit()
	{
		base.Exit();
		sm.facing = moveDirection;
	}

	public override void UpdatePhysics()
	{
		base.UpdatePhysics();
		// Flip at the end of the walk boundary
		if (!sm.col.IsTouching(sm.boundary))
		{
			moveDirection = -moveDirection;
			sm.sr.flipX = !sm.sr.flipX;
		}
		Vector2 vel = sm.rb.velocity;
		vel.x = moveDirection * sm.speed;
		sm.rb.velocity = vel;
	}
}
