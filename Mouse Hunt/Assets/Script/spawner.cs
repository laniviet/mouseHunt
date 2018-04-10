using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

    public GameObject block;

    public List<bool> Spawners;

    public int spawnNum;
    public float timer;
    public float timerMax;
    public bool spawn;
    public bool spawnGo;

    public string type;
    int num = 0;
	// Use this for initialization
	void Start () {
        for(int i = 0; i< Spawners.Count; i++)
        {
            int nameNum = i;
            if(this.gameObject.name == nameNum.ToString())
            {
                Spawners[i] = true;
            }
        }
		
	}
	
	// Update is called once per frame
	void Update () {
        if(spawnNum > 0)
        {
            timer += Time.deltaTime;
        }

        if (timer >= timerMax)
        {
            spawn = true;
            timer = 0;
            spawnBlock();
        }
		
	}

    void spawnBlock()
    {
        if (spawnGo == true)
        {
            for (int i = 0; i < Spawners.Count; i++) //Spawners.Count check for size of element
            {
                if (type[num] == '0') //takes input of string in the inspector
                {
                    Instantiate(block, transform.position, Quaternion.identity);
                    spawnNum -= 1;
                }
            }
        }
    }
}
