using UnityEngine;
using System.Collections;

public class Cambia_gravedad : MonoBehaviour {

	
	void OnCollisionEnter2D(Collision2D target){	
		if (target.transform.tag == "Player") {
			Physics2D.gravity = Physics2D.gravity * -1;
			Destroy(gameObject);
			
		}
	}
}
