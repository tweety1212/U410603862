using UnityEngine;
using System.Collections;

public class PushDominoes : MonoBehaviour {
	public GameObject dominoeStart;
	public float force = 4.0f;
	void Update () {
		if ( Input.GetKeyDown(KeyCode.A) )
		{
			dominoeStart.GetComponent<Rigidbody>().AddForce( force,0,0,ForceMode.Impulse);
		}
	}
}
