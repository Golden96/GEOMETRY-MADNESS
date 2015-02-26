using UnityEngine;
using System.Collections;

public class JumpRorate : MonoBehaviour {
	public int angulo = -90;
	public float lSpeed = 10.0f; // Set this to a value you like
	public int salto = 200;
	float rotate = 0;
	
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.Space)) {
			
			rotate = rotate + angulo;

			
		}
		
		transform.rotation = Quaternion.Lerp ( transform.rotation, Quaternion.Euler(0,0,rotate), Time.deltaTime*lSpeed);
		
	}
}
