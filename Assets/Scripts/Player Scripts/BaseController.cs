using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour {

	public Vector3 speed;

	public float x_Speed = 8f, z_Speed = 15f;

	public float accelerated = 15f, deccelarated = 10f;

	protected float rotationSpeed = 10f;
	protected float maxAngle = 10f;

	

	 
	private bool is_Slow;

	 

	void Awake () {
		 

		speed = new Vector3 (0f, 0f, z_Speed);
	}
	
	protected void MoveLeft() {
		speed = new Vector3 (-x_Speed / 2f, 0f, speed.z);
	}

	protected void MoveRight() {
		speed = new Vector3 (x_Speed / 2f, 0f, speed.z);
	}

	protected void MoveStraight() {
		speed = new Vector3 (0f, 0f, speed.z);
	}

	protected void MoveNormal() {
		if (is_Slow) {
			is_Slow = false;

		 
		}
		speed = new Vector3 (speed.x, 0f, z_Speed);
	}

	protected void MoveSlow() {
		if (!is_Slow) {
			is_Slow = true;

			 
		}
		speed = new Vector3 (speed.x, 0f, deccelarated);
	}

	protected void MoveFast() {
		speed = new Vector3 (speed.x, 0f, accelerated);
	}

} // class











































