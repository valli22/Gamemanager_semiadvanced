using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterMovementController : MonoBehaviour {

	private CharacterController _myCharacterController;

	public float movementSpeed;

	// Use this for initialization
	void Start () {
		_myCharacterController = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Walk(){
		_myCharacterController.Move (transform.forward * movementSpeed);
	}

	public void WalkBack(){
		_myCharacterController.Move (transform.forward * movementSpeed *-1);
	}

}
