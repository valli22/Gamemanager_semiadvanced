using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAttack2Controller : MyBaseAttackController {

	[SerializeField]
	GameObject attackEffectComponent1;
	[SerializeField]
	GameObject attackEffectComponent2;
	ParticleSystem particleSystemEffect1;
	ParticleSystem particleSystemEffect2;


	// Use this for initialization
	void Start () {
		particleSystemEffect1 = attackEffectComponent1.GetComponent<ParticleSystem> ();
		particleSystemEffect2 = attackEffectComponent2.GetComponent<ParticleSystem> ();
	}

	// Update is called once per frame
	void Update () {

	}

	override public void Attack(){
		if (!isAttacking) {
			particleSystemEffect1.Play ();
			particleSystemEffect2.Play ();
		}
		isAttacking = true;
	}

	override public void StopAttack(){
		if (isAttacking) {
			particleSystemEffect1.Stop ();
			particleSystemEffect2.Stop ();
		}
		isAttacking = false;
	}
}
