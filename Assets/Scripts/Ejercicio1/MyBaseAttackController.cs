using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class MyBaseAttackController : MonoBehaviour {

	protected bool isAttacking;

	abstract public void Attack ();
	abstract public void StopAttack();
}
