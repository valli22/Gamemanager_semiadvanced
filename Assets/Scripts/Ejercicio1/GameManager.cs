using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	enum gameManagerStates {MenuState, GameState};
	BaseState[] gameManagerStatesArray;
	private gameManagerStates currentState;

	List<BaseService> services;

	static public GameManager instance;
	LevelManager activeLevelManager;
	public LevelManager ActiveLevel{
		get{ return activeLevelManager;}
	}

	void Awake(){
		instance = this;
	}

	// Use this for initialization
	void Start () {
		gameManagerStatesArray = new BaseState[2];
		gameManagerStatesArray [(int)gameManagerStates.MenuState] = new MenuState ();
		gameManagerStatesArray [(int)gameManagerStates.GameState] = new GameState ();

		services = new List<BaseService> ();

		if (gameManagerStatesArray [(int)gameManagerStates.MenuState].OnStateEnter () == true)
			currentState = gameManagerStates.MenuState;

	}
	
	// Update is called once per frame
	void Update () {

		gameManagerStatesArray [(int)currentState].UpdateState ();

		foreach (BaseService service in services) {
			if(service.IsInitialized)
				service.UpdateService ();
		}
	}

	public T FindService<T>() where T:BaseService{
		foreach (BaseService service in services) {
			if (typeof(T) == service.GetType ())
				return service as T;
		}

		return null;
	}

	public void AddService<T>() where T: BaseService, new()
	{
		T newService = new T ();
		BaseService aux = newService as BaseService;
		aux.InitializeService();
	}

	public void SetActiveLevel(LevelManager newLvlManager){
		activeLevelManager = newLvlManager;
	}
}
