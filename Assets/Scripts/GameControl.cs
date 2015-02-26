	using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {
	
	public int puntuacion = 0;
	public int vidas = 3;
	
	public static GameControl gamecontrol;
	
	void Awake(){
		if (gamecontrol == null) {
			gamecontrol = this;
			DontDestroyOnLoad (gameObject);
		} else if (gamecontrol != this) {
			Destroy (this);
		}
	}
	
	public void Level2(){
		Application.LoadLevel ("escena2");
	}
}