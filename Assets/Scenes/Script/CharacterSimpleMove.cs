using UnityEngine;
using System.Collections;

public class CharacterSimpleMove : MonoBehaviour {
	CharacterController controller;
	void Start () {
		controller = GetComponent<CharacterController>();
	}

	void Update () {
		Vector3 speed = new Vector3(0, 0, 0);
		if ( controller.isGrounded )
		{
			if ( Input.GetKey(KeyCode.A) )
				speed.x = 5;
			if ( Input.GetKey(KeyCode.Space) )
				transform.Translate(0, 10, 0);
		}
		controller.SimpleMove( speed );
	}
}
