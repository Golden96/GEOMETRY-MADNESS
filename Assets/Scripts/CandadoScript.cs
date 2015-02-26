using UnityEngine;
using System.Collections;

public class CandadoScript : MonoBehaviour {

	
	void OnTriggerStay2D(Collider2D target){
		
		if (target.transform.tag == "Player") {

			}
			
			Destroy(gameObject);
			
		}
}