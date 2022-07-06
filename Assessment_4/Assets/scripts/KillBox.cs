using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{
    [SerializeField] Transform playerSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ball")
        {
            GameManager.instance.FallingDownSounds(); // play the sound of the falling ball ;
            // move player back to spawn point, reset velocity to nothing
            other.gameObject.transform.position = playerSpawnPoint.transform.position; // change this vec to playerSpawnPoint.position later
            other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
    }
}
