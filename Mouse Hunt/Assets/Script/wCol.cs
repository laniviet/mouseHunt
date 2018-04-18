using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wCol : MonoBehaviour
{

    public bool hitWest;
    // Use this for initialization
    void Start()
    {
        hitWest = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            hitWest = true;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        hitWest = false;
    }
}
