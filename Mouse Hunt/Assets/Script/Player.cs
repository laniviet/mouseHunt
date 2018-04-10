using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;      //Allows us to use SceneManager
using System.Collections.Generic;

//Player inherits from MovingObject, our base class for objects that can move, Enemy also inherits from this.
public class Player : MonoBehaviour
{
    public float speed;             //Floating point variable to store the player's movement speed.
    private float halfSpd;

    public bool hitUp;

    private Rigidbody2D rb;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

    public Transform UCol;
    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb = GetComponent<Rigidbody2D>();

        halfSpd = speed / 2;
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        InputMovement();

        hitUp = Physics2D.Linecast(transform.position, UCol.position, 1 << LayerMask.NameToLayer("moveBlock"));
    }

    void InputMovement()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.position += transform.up * speed * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            transform.position -= transform.up * speed * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.position -= transform.right * speed * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        InputDiagonalMove();
    }

    void InputDiagonalMove()
    {
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow)) {
            transform.position += transform.up * halfSpd * Time.deltaTime;
            transform.position += transform.right * halfSpd * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow)) {
            transform.position += transform.up * halfSpd * Time.deltaTime;
            transform.position -= transform.right * halfSpd * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow)) {
            transform.position -= transform.up * halfSpd * Time.deltaTime;
            transform.position += transform.right * halfSpd * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow)) {
            transform.position -= transform.up * halfSpd * Time.deltaTime;
            transform.position -= transform.right * halfSpd * Time.deltaTime;
        }
    }
}