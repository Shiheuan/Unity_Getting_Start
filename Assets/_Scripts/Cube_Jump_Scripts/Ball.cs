using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<Rigidbody>().velocity = new Vector3(8.0f, 8.0f, 0.0f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnBecameInvisible() {
		Destroy(this.gameObject);
	}
}
