	using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {
	
	public int puntuacion = 0;
	public int vidas = 3;
	
	public static GameControl gamecontrol;
	public static bool gravedad_abajo = true;
	
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

	void Update () {
		if (Physics2D.gravity.y < 0) {
						gravedad_abajo = true;
				} else {
						gravedad_abajo = false;		
				}
	}
	
}