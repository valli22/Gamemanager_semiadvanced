using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAttackController : MonoBehaviour {

	[SerializeField]
	GameObject attackEffectComponent;
	ParticleSystem particleSystemEffect;

	bool isAttacking;

	// Use this for initialization
	void Start () {
		particleSystemEffect = attackEffectComponent.GetComponent<ParticleSystem> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Attack(){
		if(!isAttacking)
			particleSystemEffect.Play ();
		isAttacking = true;
	}

	public void StopAttack(){
		if(isAttacking)
			particleSystemEffect.Stop ();
		isAttacking = false;
	}
}
