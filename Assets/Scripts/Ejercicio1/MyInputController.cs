using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyInputController : MonoBehaviour {

	MyAnimatorController myAnimatorController;
	MyCharacterMovementController myCharacterController;
	MyBaseAttackController myAttackController;

	// Use this for initialization
	void Start () {
		myAnimatorController = GetComponent<MyAnimatorController> ();
		myCharacterController = GetComponent<MyCharacterMovementController> ();
		myAttackController = GetComponent<MyBaseAttackController> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			myCharacterController.Walk ();
			myAnimatorController.Walk ();
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			myCharacterController.WalkBack ();
			myAnimatorController.WalkBack ();
		} else if (Input.GetKey (KeyCode.A)) {
			myAttackController.Attack ();
			myAnimatorController.Attack ();
		} else {
			myAnimatorController.Stop ();
		}
	}
}
