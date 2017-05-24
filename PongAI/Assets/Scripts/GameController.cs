using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public static GameController Instance
	{ 
		get
		{
			if (instance == null) {
				GameObject aux = Instantiate (new GameObject ()) as GameObject;
				instance = aux.AddComponent<GameController> ();
				return instance;
			}
			return instance;
		}
	}
	private static GameController instance;

	void Awake()
	{
		instance = this;
		InitGame();
	}

	void InitGame(){
		
	}
}
