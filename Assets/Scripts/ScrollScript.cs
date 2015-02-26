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
			rigidbody2D.velocity = new Vector2(velocidad,rigidbody2D.velocity.y);  
		}
	}
}
