using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax, yMax, yMin;
}

public class PlayerController : MonoBehaviour {

    public Rigidbody rigid;
    public float speed = 20f;
    public Boundary boundary; 


    // Use this for initialization
    void Start ()
    {
        rigid = GetComponent<Rigidbody>();
	}
    
	// Update is called once per frame
	void FixedUpdate()
    {
        

        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(0.0f, 0.0f, moveVertical) * speed;

        rigid.velocity = movement;

        // Limits how far the player can go up or down on the screen
        rigid.position = new Vector3(
            Mathf.Clamp(rigid.position.x, boundary.xMin, boundary.xMax),
            Mathf.Clamp(rigid.position.y, boundary.yMin, boundary.yMax), 
            Mathf.Clamp(rigid.position.z, boundary.zMin, boundary.zMax)
        );
    }
}
