using UnityEngine;
using System.Collections;

public class CharacterMove : MonoBehaviour {
    
    CharacterController cc;
    public float speed = 3;
    // Use this for initialization
    void Start () {
        cc = GetComponent<CharacterController>();
    }
    
    // Update is called once per frame
    void Update () {
        if (cc != null)
        {
            if (Input.GetKey(KeyCode.A))
                cc.Move(new Vector3(speed * Time.deltaTime, 0, 0));
            if (Input.GetKey(KeyCode.D))
                cc.Move(new Vector3(-speed * Time.deltaTime, 0, 0));
            if (Input.GetKey(KeyCode.W))
                cc.Move(new Vector3(0, 0, speed * Time.deltaTime));
            if (Input.GetKey(KeyCode.S))
                cc.Move(new Vector3(0, 0, -speed * Time.deltaTime));
        }
    }
}
