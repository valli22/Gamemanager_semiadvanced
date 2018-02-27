using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public delegate void AttackDelegate();
	public delegate void WalkDelegate();
	public delegate void StopDelegate();

	public event AttackDelegate AttackEvent;
	public event WalkDelegate WalkEvent;
	public event StopDelegate StopEvent;

	float elapsedTime;
	bool isActivated;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.W)) {
			WalkEvent ();
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			StopEvent ();
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			AttackEvent ();
		}


		/*if (!isActivated) {
		
			elapsedTime += Time.deltaTime;
			if (elapsedTime > 3f) {
				StopEvent ();
			}else if (elapsedTime > 2f) {
				AttackEvent ();
			}else if (elapsedTime > 1.5f) {
				StopEvent ();
			}else if (elapsedTime > 0.2f) {
				WalkEvent ();
			}

		}*/

	}
}
