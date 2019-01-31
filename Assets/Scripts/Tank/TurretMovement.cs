using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMovement : MonoBehaviour {
	float TurretTurn;
	string move_name;
	public int playerNum;
	// Use this for initialization
	void Start () {
		move_name = "Lift"+playerNum;
	}
	
	// Update is called once per frame
	void Update () {
		TurretTurn = Input.GetAxis (move_name);

	}

	private void FixedUpdate ()
	{	
		if ((transform.rotation.x < 0.13 && transform.rotation.x > -0.13) || (transform.rotation.x > 0.13 && TurretTurn < 0) || (transform.rotation.x < 0.13 && TurretTurn > 0)) {
			Vector3 angle = new Vector3 (TurretTurn * Time.deltaTime * 50f, 0f, 0f);
			transform.Rotate (angle);
		}
	}
}
