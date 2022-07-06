using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float smoothing;
    public float snapbackSpeed;

    private Camera_Controller camera;
    private Quaternion startingRotation;

    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.FindObjectOfType<Camera>().GetComponent<Camera_Controller>();
        startingRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion camRot = camera.GetRotation();
        camRot = Quaternion.Normalize(camRot);

        if (Input.GetAxis ("Vertical") > .2)
        {
            transform.Rotate(new Vector3(0, 0, 1) * smoothing * Time.deltaTime);
            //transform.Rotate(camera.transform.forward, smoothing * Time.deltaTime, Space.World);
        }
        if (Input.GetAxis("Vertical") < -.2)
        {
            transform.Rotate(new Vector3(0, 0, -1) * smoothing * Time.deltaTime);
            //transform.Rotate(camera.transform.forward, smoothing * -1 * Time.deltaTime, Space.World);
        }
        if (Input.GetAxis("Horizontal") > .2)
        {
            transform.Rotate(new Vector3(1, 0, 0) * smoothing * Time.deltaTime);
            //transform.Rotate(camera.transform.up, smoothing * Time.deltaTime, Space.World);
        }
        if (Input.GetAxis("Horizontal") < -.2)
        {
            transform.Rotate(new Vector3(-1, 0, 0) * smoothing * Time.deltaTime);
            //transform.Rotate(camera.transform.up, smoothing * -1 * Time.deltaTime, Space.World);
        }
        
        if(Input.GetAxis("Horizontal") <= 0.2 && Input.GetAxis("Horizontal") >= -0.2 && Input.GetAxis("Vertical") <= 0.2 && Input.GetAxis("Vertical") >= -0.2)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, startingRotation, smoothing * snapbackSpeed * Time.deltaTime);
        }

        transform.rotation = new Quaternion(transform.rotation.x, startingRotation.y, transform.rotation.z, transform.rotation.w);

        //if (Input.GetAxis("RStickHorizontal") > 0) camera.Rotation("right");
        //if (Input.GetAxis("RStickHorizontal") < 0) camera.Rotation("left");
        //if (Input.GetAxis("RStickVertical") > 0) camera.Rotation("up");
        //if (Input.GetAxis("RStickVertical") < 0) camera.Rotation("down");
    }
}
