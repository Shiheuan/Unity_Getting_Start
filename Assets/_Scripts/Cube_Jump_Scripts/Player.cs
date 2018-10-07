using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	protected float jump_speed = 10.0f;
    public float jump_height = 3.0f;
    public bool is_landing = false;
	// Use this for initialization
	void Start () {
        this.is_landing = false;
        jump_speed = Mathf.Sqrt(2.0f * Mathf.Abs(Physics.gravity.y) * this.jump_height);
    }
	
	// Update is called once per frame
	void Update () {
        if (this.is_landing)
        {
            if (Input.GetMouseButtonDown(0))
            {
                this.is_landing = false;
                this.GetComponent<Rigidbody>().velocity = Vector3.up * this.jump_speed;
            }
        }   
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            this.is_landing = true;
        }
    }
}
