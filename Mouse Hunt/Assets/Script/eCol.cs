using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eCol : MonoBehaviour
{

    public bool hitEast;

    // Use this for initialization
    void Start()
    {
        hitEast = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            hitEast = true;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        hitEast = false;
    }
}
