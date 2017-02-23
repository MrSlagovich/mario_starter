using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

    public int speed = 4;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
       // this.transform.Translate() = Vector3.up * speed;
        this.transform.Translate(Vector3.right * Time.deltaTime);
	}
}
