using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// / this script is for making the camera follow the ball smoothly
/// </summary>
public class Camera_Controller : MonoBehaviour
{
    public GameObject Ball; // reference to the ball
    Vector3 offset; // position of the camera 
    private float distance;
    public float LerpRate; // rate by which the camera change its position to follow the ball
    public bool Gameover;
    //Follower follower;
    // Start is called before the first frame update
    void Start()
    {
        
        offset = Ball.transform.position - transform.position; // distance between the ball and the camera 
       // follower = transform.parent.gameObject;
        distance = Vector3.Distance(transform.position, Ball.transform.position);
        if (distance < 0) distance *= -1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!Gameover)
        {
            //Follow();
        }

        //transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, 0f, transform.rotation.w);
    }

    void Follow()
    {
        // make the smooth movement of the camera 
        // learnt from the vedio on internet // cool stuff
        Vector3 pos = transform.position; // camera position
        //Vector3 TragetPos = Ball.transform.position - offset; // target position to acheive 
        //Vector3 targetPos = 
        //pos = Vector3.Lerp(pos, TragetPos, LerpRate * Time.deltaTime);
        transform.position = pos;
        //Vector3.Lerp(transform.position, Ball.transform.position, LerpRate * Time.deltaTime);

    }

    //public void Rotation(string direction)
    //{
    //    if (direction == "up") transform.Rotate(new Vector3(1, 0, 0), 20 * Time.deltaTime, Space.World);
    //    else if (direction == "down") transform.Rotate(new Vector3(1, 0, 0), -20 * Time.deltaTime, Space.World);
    //    else if (direction == "left") transform.Rotate(new Vector3(0, 1, 0), -20 * Time.deltaTime, Space.World);
    //    else if (direction == "right") transform.parent.transform.Rotate(new Vector3(0, 1, 0), 20 * Time.deltaTime, Space.World);
    //}

    public Quaternion GetRotation()
    {
        return transform.parent.rotation;
    }
}
