using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hole_Controller : MonoBehaviour
{
    [SerializeField] int nextSceneNum;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "ball")
        {
            //change level
            SceneManager.LoadScene(nextSceneNum);
        }
    }
}
