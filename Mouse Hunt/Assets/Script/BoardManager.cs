using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{

    public int columns = 9;
    public int rows = 9;

    public GameObject block;
    public GameObject mouse;

    private Transform blocksHolder;



    // Use this for initialization
    void Start()
    {
        setUpBoard();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void setUpBoard()
    {
        blocksHolder = new GameObject("Blocks").transform;

        for (int x = 0; x < rows; x++) {
            for (int y = 0; y < columns; y++) {
                if ((x == (rows / 2)) && (y == (columns / 2))) {
                    GameObject player = Instantiate(mouse, new Vector3(x, y, 0f), Quaternion.identity) as GameObject;
                    Camera.main.transform.position = new Vector3(x, y, -1);
                } else {
                    // toInstantiate is prefab choosen, Quaternion.identity means created with no rotation, as GameObject means casting to GameObject
                    GameObject instance = Instantiate(block, new Vector3(x, y, 0f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(blocksHolder);
                }
            }
        }
    }

}
