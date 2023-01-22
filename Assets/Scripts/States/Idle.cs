using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : Moving
{

    public Idle(EnemySM stateMachine) : base("Idle", stateMachine) {}

	public override void Enter()
	{
		base.Enter();
		sm.sr.sprite = sm.idleSprite;
	}

	public override void UpdateLogic()
	{
		base.UpdateLogic();
		if (sm.playerInRange == true) 
		{
			sm.ChangeState(sm.meleeState);
		}
	}

}
