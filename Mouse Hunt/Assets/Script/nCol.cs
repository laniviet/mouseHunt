using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nCol : MonoBehaviour {

    public bool hitNorth;
	// Use this for initialization
	void Start () {
        hitNorth = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            hitNorth = true;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        hitNorth = false;
    }
}
