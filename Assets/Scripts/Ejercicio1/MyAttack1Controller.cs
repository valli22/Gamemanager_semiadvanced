using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAttack1Controller : MyBaseAttackController {

	[SerializeField]
	GameObject attackEffectComponent;
	ParticleSystem particleSystemEffect;


	// Use this for initialization
	void Start () {
		particleSystemEffect = attackEffectComponent.GetComponent<ParticleSystem> ();
	}

	// Update is called once per frame
	void Update () {

	}

	override public void Attack(){
		if(!isAttacking)
			particleSystemEffect.Play ();
		isAttacking = true;
	}

	override public void StopAttack(){
		if(isAttacking)
			particleSystemEffect.Stop ();
		isAttacking = false;
	}
}
