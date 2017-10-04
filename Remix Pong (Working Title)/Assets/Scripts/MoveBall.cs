using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MoveBall : MonoBehaviour {
    
    public Rigidbody rigid;
    public float speed = 10f;
    // Use this for initialization

    void Start () {
        rigid = GetComponent<Rigidbody>();

	}

    // Update is called once per frame

    
    bool ballThrown = true;
    void FixedUpdate ()
    {
        if (ballThrown == true)
        {
            rigid.AddForce(speed, 0f, 0f, ForceMode.Impulse);


            ballThrown = false;
        }

    } //End of FixedUpdate
} //End of MoveBall class
