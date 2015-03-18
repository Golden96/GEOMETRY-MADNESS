using UnityEngine;
using System.Collections;

public class MuertoScript : MonoBehaviour {
	public bool destroyOnCollision = false;
	public bool destroyOnTrigger = true;
		
	
	void OnCollisionStay2D(Collision2D target){	
		if (target.transform.tag == "Obstacle") {
			Destroy(gameObject);
			Application.LoadLevel("01");

			}
		}
	}

