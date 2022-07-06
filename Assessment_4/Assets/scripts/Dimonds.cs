using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dimonds : MonoBehaviour
{
    public ParticleSystem explosion;
    // public AudioSource coinCollect;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    // if the player touch the dimoand make it destroy
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == "ball")
        {

            Destroy(gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);  // enable the explosion partcile appear when the plaer hits the diamonds
            GameManager.instance.PointsCollect();  // make the sound of the coins collect
            GameManager.instance.IncrementScore();  // increment the score by 1



        }
    }
}
