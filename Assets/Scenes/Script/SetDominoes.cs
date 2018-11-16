using UnityEngine;
using System.Collections;

public class SetDominoes : MonoBehaviour {
	public GameObject dominoePrefab;
	public GameObject dominoeEnd;
    public GameObject dominoestart;
    public int NumCenterDom = 25;
	void Start() {
		Vector3 dir = dominoeEnd.transform.position - dominoestart.transform.position;
		float interval = dir.magnitude / (NumCenterDom+1);
		dir.Normalize();
		for (int i=1; i<=NumCenterDom; i++){
			GameObject newDom = (GameObject)Instantiate(dominoePrefab);
			newDom.transform.position = dominoestart. transform.position + dir*interval*i;
			newDom.transform.rotation = dominoestart.transform.rotation;
		}
	}

    public float force = 4.0f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            dominoestart.GetComponent<Rigidbody>().AddForce(force, 0, 0, ForceMode.Impulse);
        }
    }
}
