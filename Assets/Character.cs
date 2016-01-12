using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	public float jumpSpeed = 2.0f;
	public float walkSpeed = 5.0f;
	public Rigidbody2D phys;
	
	public int maxJumps = 1;
	private int jumpCount = 0;
	public bool isOnGround = false;
	// Use this for initialization
	void Start (){
		phys = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update (){
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.UpArrow)) {
			Jump ();
		}
		move ();
		//Walk ();
	}
	
	/*void Walk(){
		Vector2 newVelocity = new Vector2(Input.GetAxis("Horizontal") * walkSpeed ,phys.velocity.y);
		phys.velocity = newVelocity;
	}*/
	void move(){
		Vector2 newVelocity = new Vector2(walkSpeed, phys.velocity.y);
		phys.velocity = newVelocity;
	}
	void Jump(){
		if (jumpCount > 0){
			Vector2 newVelocity = new Vector2(phys.velocity.x, jumpSpeed);
			phys.velocity = newVelocity;
			jumpCount--;
		}
	}
	
	public void ResetJump(){
		jumpCount = maxJumps;
	}
}