using UnityEngine;
using System.Collections;

public class SwitchCollisionEvent : MonoBehaviour {
	public MyCharacter character;
	bool SwitchEnable = true;

	void OnCollisionEnter(Collision collision) {
		if (SwitchEnable == true )
		{
			character.CharacterWalk();
	        SwitchEnable = false;
		}
	}
}
