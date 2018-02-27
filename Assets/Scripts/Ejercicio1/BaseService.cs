using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class BaseService {

	protected bool isInitialized;

	public bool IsInitialized{
		get { return isInitialized;}
	}

	virtual public void InitializeService(){
		isInitialized = true;
	}

	abstract public void UpdateService ();

	virtual public void ReleaseService(){
		isInitialized = false;
	}

}
