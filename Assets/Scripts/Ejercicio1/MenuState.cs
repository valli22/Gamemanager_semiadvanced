using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuState : BaseState {

	override public bool OnStateEnter (){
		GameManager.instance.AddService<LightService> ();
		return true;
	}
	override public bool UpdateState (){
		return true;
	}
	override public bool OnStateExit (){
		return true;
	}

}
