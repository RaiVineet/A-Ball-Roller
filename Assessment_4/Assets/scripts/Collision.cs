using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{


   
     Rigidbody rb;
    [SerializeField] float speed  = 500f;

    //public float attackImpulse  = 2f;
    // Start is called before the first frame update

    void Awake()
    {
        rb = GameObject.Find("Player").GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "ball")
        {
            Vector3 Dir = collision.transform.position - transform.position;
            Dir = -Dir.normalized;

            collision.gameObject.GetComponent<Rigidbody>().AddForce(Dir * speed);
            ////rb.velocity = new Vector3(speed * Time.deltaTime, 0f , speed * Time.deltaTime);
            //rb.AddForce((collision.transform.position - transform.position) * attackImpulse * rb.mass, ForceMode.Impulse);
            //collision.gameObject.GetComponent<Rigidbody>().AddForce(speed, 0, 0);
        }
    }
}
