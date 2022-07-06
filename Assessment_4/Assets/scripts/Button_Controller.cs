using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Controller : MonoBehaviour
{
    [SerializeField] Triggered_Object_Controller obstacle; // the obstacle the button is linked to

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "ball")
        {
            Debug.Log("button pressed");
            // trigger linked obstacle
            obstacle.Trigger();
        }
    }
}
