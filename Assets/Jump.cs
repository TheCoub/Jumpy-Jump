using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	public Character pc;

	void Start (){

	}

	void OnTriggerEnter2D(Collider2D collider){
		GameObject collidedwith = collider.gameObject;
		pc.isOnGround = true;
		pc.ResetJump();
	}
	void OnTriggerExit2D(Collider2D collider){
		GameObject collidedwith = collider.gameObject;
		pc.isOnGround = false;
	}
}