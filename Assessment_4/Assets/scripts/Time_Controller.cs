using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_Controller : MonoBehaviour
{
    public Ball_Controller Ball;

    public float isTime = 0.25f;  // slow down time
    public bool completeTime = false;
    public float slowdownlength = 2f;

    bool gamestart;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // slow the time 

        if (Input.GetKeyDown(KeyCode.E))
        {
            slowTime();

            // make the ball move in the up direction 
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                Ball.transform.Translate(Vector3.forward * Time.deltaTime);
            }

        }

        // bring time back to the normal 
        if (Input.GetKeyDown(KeyCode.Q))
        {
            NormalTime();
        }


        Time.timeScale += (1f / slowdownlength) * Time.unscaledDeltaTime;  // make the time back to the normal
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);   // time must lie between the 2 values 




    }

    void slowTime()
    {

        Time.timeScale = 0.05f;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;





    }
    void NormalTime()
    {
        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
    }
}
