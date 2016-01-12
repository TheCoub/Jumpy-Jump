using UnityEngine;
using System.Collections;

public class TurnAround : MonoBehaviour {

	public Character pc;
	public Renderer view;

	void Start () {
	
		pc = GetComponent<Character> ();
	}
	void OnTriggerEnter2D(Collider2D collider){
		GameObject collidedwith = collider.gameObject;

		pc.walkSpeed = pc.walkSpeed * -1;
	}
	}