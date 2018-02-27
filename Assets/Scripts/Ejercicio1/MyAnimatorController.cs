using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAnimatorController : MonoBehaviour {

	private Animator _myAnimator;

	// Use this for initialization
	void Start () {
		_myAnimator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Walk(){
		_myAnimator.SetInteger ("MovementState",1);
	}

	public void Stop(){
		_myAnimator.SetInteger ("MovementState",0);
	}

	public void WalkBack(){
		_myAnimator.SetInteger ("MovementState",2);
	}

	public void Attack(){
		_myAnimator.SetInteger ("MovementState",3);
	}
}
