using UnityEngine;
using System.Collections;

public class SaltoScript : MonoBehaviour {
	public int angulo = -90;
	public float lSpeed = 10.0f; // Set this to a value you like
	public int salto = 200;
	public float rotate_speed = 0.2f;
	float rotate = 0;
	bool isRotating = false;
	public float jumpSpeed = 5f;
	public bool standing;
	private float initJump;
	
	void Start(){
		initJump = jumpSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		var absVelY = Mathf.Abs(rigidbody2D.velocity.y);
		if(absVelY <= .05f){
			standing = true;
			
		}else{
			standing = false;
		}
		
		if(  (Input.GetKeyDown("up") || Input.GetKey("space")) && standing){
			rigidbody2D.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
			var rnd = Mathf.Round(Random.Range(1,3));
			//var rotacion = angulo; //*);
			rotate = angulo*rnd;
			StartCoroutine(RotateAround(-rotate,rotate_speed+rotate_speed*rnd));
			
		}
	}
	
	IEnumerator RotateAround(float degrees, float duration){
		isRotating = true;
		float d = 0;
		Quaternion q;
		Quaternion startRot = transform.rotation;
		Vector3 axis = new Vector3(0,0,1);
		float progress = 0;
		while(progress <= 1){
			d = Mathf.Lerp(0, degrees, progress);
			q = Quaternion.AngleAxis(d, axis);
			transform.rotation = startRot*q;
			progress += Time.deltaTime/duration;
			yield return null;
		}
		transform.rotation = startRot*Quaternion.AngleAxis(degrees, axis);
		isRotating = false;
	}
}