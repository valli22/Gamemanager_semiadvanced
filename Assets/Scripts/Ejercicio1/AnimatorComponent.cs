using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorComponent : MonoBehaviour {

	Animator animatorComponent;

	LevelManager.AttackDelegate attackDelegate;
	LevelManager.WalkDelegate walkDelegate;
	LevelManager.StopDelegate stopDelegate;

	LevelManager lvlManager;
	// Use this for initialization
	void Start () {
		lvlManager = GameObject.Find ("LevelManager").GetComponent<LevelManager>();
		animatorComponent = GetComponent<Animator> ();
		attackDelegate = new LevelManager.AttackDelegate(Attack);
		walkDelegate = new LevelManager.WalkDelegate(Walk);
		stopDelegate = new LevelManager.StopDelegate(Stop);

		lvlManager.AttackEvent += attackDelegate;
		lvlManager.WalkEvent += walkDelegate;
		lvlManager.StopEvent += stopDelegate;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Attack(){
		animatorComponent.SetInteger ("MovementState",2);
	}

	public void Walk(){
		animatorComponent.SetInteger ("MovementState",1);
	}

	public void Stop(){
		animatorComponent.SetInteger ("MovementState",0);
	}

	public void OnDestroy(){
		lvlManager.AttackEvent -= attackDelegate;
		lvlManager.WalkEvent -= walkDelegate;
		lvlManager.StopEvent -= stopDelegate;
	}
}
