using UnityEngine;
using System.Collections;

public class GoalTrigger : MonoBehaviour {
	public MyCharacter character;
	public GameObject FinishText;

	void OnTriggerEnter (Collider other) {
		if ( other.name == "Constructor" ){
			FinishText.SetActive(true);
			character.CharacterStop();
		}
	}
}
