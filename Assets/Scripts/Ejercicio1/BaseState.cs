using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class BaseState{

	abstract public bool OnStateEnter ();
	abstract public bool UpdateState ();
	abstract public bool OnStateExit ();

}
