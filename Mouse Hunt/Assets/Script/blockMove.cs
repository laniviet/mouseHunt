using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockMove : MonoBehaviour {

    //Scripts
    public Player player;
    public nCol nCol;
    public eCol eCol;
    public wCol wCol;
    public sCol sCol;

    public bool move;

  
	// Use this for initialization
	void Start () {
        
        move = false;
	}
	
	// Update is called once per frame
	void Update () {
	   if(nCol.hitNorth == true)
        {
            transform.position -= transform.up * player.speed * Time.deltaTime;
        }
       if(eCol.hitEast == true)
        {
            transform.position -= transform.right * player.speed * Time.deltaTime;
        }
       if(wCol.hitWest == true)
        {
            transform.position += transform.right * player.speed * Time.deltaTime;
        }
       if(sCol.hitSouth == true)
        {
            transform.position += transform.up * player.speed * Time.deltaTime;
        }
	}

    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            print("block touch");
            move = true;
        }
      
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        print("NO touch");
        move = false;
    }
}
