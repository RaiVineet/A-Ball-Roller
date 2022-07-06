using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggered_Object_Controller : MonoBehaviour
{
    [SerializeField] Transform target;

    [SerializeField] float movementSpeed;

    private bool isTriggered;

    void Awake()
    {
        isTriggered = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(isTriggered);
        if (isTriggered)
        {
            if (transform.position != target.transform.position) transform.position = Vector3.MoveTowards(transform.position, target.transform.position, movementSpeed * Time.deltaTime);
        }
    }

    public void Trigger()
    {
        isTriggered = true;
    }
}
