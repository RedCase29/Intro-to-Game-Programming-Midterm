using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDMovement : MonoBehaviour
{
    public float speed = 0.01f;  //defines the players speed

    public KeyCode upKey = KeyCode.W;  //variable to move up
    public KeyCode downKey = KeyCode.S;  //variable to move down
    public KeyCode leftKey = KeyCode.A;  //variable to move left
    public KeyCode rightKey = KeyCode.D;  //variable to move right
    private Rigidbody2D rb2d;

    float yborder = 5.5f;    //variable for vertical border
    float xborder = 12;    //variable for horizontal border
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        if (Input.GetKey(upKey))
        { //if the up key is pressed
            newPosition.y += speed; //move newPosition up
        }
        if (Input.GetKey(downKey))//if the down key is pressed
        {
            newPosition.y -= speed;//move newPosition down
        }
        if (Input.GetKey(rightKey))  //if the right key is pressed
        {
            newPosition.x += speed;  //move newPosition right
        }
        if (Input.GetKey(leftKey)) //if the left key is pressed
        {
            newPosition.x -= speed;  //move newPosition left
        }


        if (newPosition.y > yborder)
        {
            newPosition.y = -yborder;
        }

        if (newPosition.y < -yborder)
        {
            newPosition.y = yborder;
        }

        if (newPosition.x > xborder)
        {
            newPosition.x = -xborder;
        }

        if (newPosition.x < -xborder)
        {
            newPosition.x = xborder;
        }

        transform.position = newPosition;
    }
}
