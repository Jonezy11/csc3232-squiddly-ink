using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : Moving
{
    public Melee(EnemySM stateMachine) : base("Melee", stateMachine) { }

	public override void Enter()
	{
		base.Enter();
		sm.sr.sprite = sm.meleeSprite;
	}

	public override void UpdateLogic()
	{
		base.UpdateLogic();
		if (sm.playerInRange == false)
		{
			sm.ChangeState(sm.idleState);
		}
	}

	public override void UpdatePhysics()
	{
		base.UpdatePhysics();
		
		// Reduce the player's health upon collision
		if (sm.col.IsTouching(sm.player))
		{
			sm.player.gameObject.GetComponent<HealthManager>().takeDamage(1);
		}
	}
}
