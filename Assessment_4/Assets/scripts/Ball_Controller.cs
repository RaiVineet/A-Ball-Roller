using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour
{
    public float speed = 20f;  // speed of the bal
    Rigidbody rb;  // rigidbody
    public GameObject spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // get rigidbody component
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float InputX = Input.GetAxis("Horizontal");
        float InputY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(InputY, 0.0f, InputX);

        rb.AddForce(movement * speed);
        //rb.AddForce(Vector3.down, ForceMode.Acceleration);
        //rb.AddForce(movement * speed);

        //Debug.Log(GameStart);
        //if (!GameStart)
        //{
        //    // if the player press the space button then the ball will move 
        //    if (Input.GetKeyDown(KeyCode.Space))
        //    {
        //        rb.velocity = new Vector3(speed, 0, speed);  // make the ball move in the x direction 
        //        GameStart = true;    // the game will start
        //    }
        //}

        ////HandleDirection();
    }

   

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            transform.position = spawnPoint.transform.position;
            transform.rotation = spawnPoint.transform.rotation;
        }
    }
}
