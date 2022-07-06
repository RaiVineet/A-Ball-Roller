using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public GameObject ball;
    private Camera camera;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ball.transform.position;
        transform.rotation = new Quaternion(0, transform.rotation.y, transform.rotation.z, transform.rotation.w);

        if (Input.GetAxis("RStickHorizontal") > 0) transform.Rotate(new Vector3(0, 1, 0), 20 * rotationSpeed * Time.deltaTime, Space.World);
        if (Input.GetAxis("RStickHorizontal") < 0) transform.Rotate(new Vector3(0, 1, 0), -20 * rotationSpeed * Time.deltaTime, Space.World);
        if (Input.GetAxis("RStickVertical") > 0) transform.Rotate(new Vector3(0, 0, 1), 20 * Time.deltaTime, Space.World);
        if (Input.GetAxis("RStickVertical") < 0) transform.Rotate(new Vector3(0, 0, 1), -20 * Time.deltaTime, Space.World);
    }
}
