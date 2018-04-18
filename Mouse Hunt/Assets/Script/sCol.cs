using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sCol : MonoBehaviour
{

    public bool hitSouth;
    // Use this for initialization
    void Start()
    {
        hitSouth = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            hitSouth = true;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        hitSouth = false;
    }
}