using UnityEngine;
using System.Collections;

public class ScrollScript : MonoBehaviour {
	public bool enMovimiento = true;
	public float velocidad;

	// Use this for initialization
	void Start () {
		}

	void Update () {
		if(enMovimiento){
			GetComponent<Rigidbody2D>().velocity = new Vector2(velocidad,GetComponent<Rigidbody2D>().velocity.y);  
		}
	}
}
