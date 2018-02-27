using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : BaseState {
	
	override public bool OnStateEnter (){
		return true;
	}
	override public bool UpdateState (){
		return true;
	}
	override public bool OnStateExit (){
		return true;
	}

}
