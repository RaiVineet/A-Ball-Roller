using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{





    // Start is called before the first frame update
    void Start()
    {

        DontDestroyOnLoad(gameObject);
        //for (int i = 0; i < Object.FindObjectsOfType< DontDestroyOnLoad>().Length; i++)
        //{

        //    if (Object.FindObjectsOfType<DontDestroyOnLoad>()[i] != this)
        //    {
        //        if (Object.FindObjectsOfType<DontDestroyOnLoad>()[i].name == gameObject.name)
        //        {
        //            Destroy(gameObject);
        //        }
        //    }
            
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
