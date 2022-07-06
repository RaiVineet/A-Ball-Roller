using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject projectile;
    float rateoffire = 1f;
   // public Transform gunpoint;


    private void Start()
    {
       // gunpoint = GetComponentInChildren<GunPoints>().transform;
    }
    public  float GetrateofFire()
    {
        return rateoffire;
    }

    public void Fire()
    {
        Instantiate(projectile, transform.position , transform.rotation);
        Destroy(projectile, 3f);  /// destroy the gameobject in 3f;
        Debug.Log("Porjectile_Destroy");
    }
}
