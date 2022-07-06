using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Object_Controller : MonoBehaviour
{
    [SerializeField] Transform[] targets = new Transform[2];

    [SerializeField] float moveSpeed;
    [SerializeField] float delay;

    private int targetNum; // 0 = target 1, 1 = target 2
    private float delayTimer; // keeps track of how long object has been at destination
    private bool moving;

    // Start is called before the first frame update
    void Start()
    {
        delayTimer = 0;
        moving = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != targets[targetNum].transform.position) // if not at the position
        {
            transform.position = Vector3.MoveTowards(transform.position, targets[targetNum].transform.position, moveSpeed * Time.deltaTime);
        }
        else // if at the position
        {
            moving = false;
            delayTimer += Time.deltaTime;

            if (delayTimer >= delay) // if object has been waiting for long enough, update target and start movement again
            {
                if (targetNum == 0) targetNum = 1;
                else if (targetNum == 1) targetNum = 0;
                moving = true;
                delayTimer = 0;
            }
        }
    }
}
