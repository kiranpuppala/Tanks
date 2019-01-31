using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShooterMovement : MonoBehaviour {

	 Transform player;
//	PlayerHealth playerHealth;
//	EnemyHealth enemyHealth;
	UnityEngine.AI.NavMeshAgent nav;
	public Rigidbody bullet;
	public Transform gunTransform;
	public float bulletForce;

	void Awake ()
	{
		player = GameObject.FindGameObjectWithTag ("PlayerTank").transform;
//		playerHealth = player.GetComponent <PlayerHealth> ();
//		enemyHealth = GetComponent <EnemyHealth> ();
		nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
	}


	void Update ()
	{
//		Debug.Log ("PLAYER UPDATE");
//		if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
//		{


//		Vector3 offSetVector = new Vector3 (gunTransform.position.x, gunTransform.position.y, gunTransform.position.z);

		if (nav.remainingDistance <= nav.stoppingDistance) {
			
			Rigidbody m_Bullet = Instantiate (bullet, gunTransform.position, gunTransform.rotation) as Rigidbody;
			m_Bullet.velocity = bulletForce * gunTransform.forward;

		}

		nav.SetDestination (player.position);
//		}
//		else
//		{
//			nav.enabled = false;
//		}

	}
}
