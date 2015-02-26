using UnityEngine;
using System.Collections;

public class SaltoScript : MonoBehaviour {
	public int angulo = -90;
	public float lSpeed = 10.0f; // Set this to a value you like
	public int salto = 200;
	float rotate = 0;
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
		
		if(  (Input.GetKeyDown("up") || Input.GetKeyDown("space")) && standing){
			rigidbody2D.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
			rotate = rotate + angulo;
			//rigidbody2D.AddTorque(-45);
		}
		transform.rotation = Quaternion.Lerp ( transform.rotation, Quaternion.Euler(0,0,rotate), Time.deltaTime*lSpeed);
	}
}