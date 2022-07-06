using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float TurretRange = 13f;
    public float TurretRotationSpeed = 5f;

    public Transform PlayerTransform;
    private Gun CurrentGun;


    // bullet fireing rate
    float fireRate;
    float fireRateDelta;

    private void Start()
    {
        PlayerTransform = FindObjectOfType<Ball_Controller>().transform;
        CurrentGun = GetComponentInChildren<Gun>();
        fireRate = CurrentGun.GetrateofFire();
    }
   
    private void Update()
    {
        Vector3 playerGoundPos = new Vector3(PlayerTransform.position.x, transform.position.y, PlayerTransform.position.z);


        if(Vector3.Distance(transform.position , playerGoundPos)  > TurretRange)
        {
            return;
        }


        // Rotate Towards the player
        Vector3 playerDirection = playerGoundPos - transform.position;
        float turretRotationStep = TurretRotationSpeed * Time.deltaTime;
        Vector3 newLookDirection = Vector3.RotateTowards(transform.forward, playerDirection, turretRotationStep , 0f);

        transform.rotation = Quaternion.LookRotation(newLookDirection);




        fireRateDelta -= Time.deltaTime;
        if (fireRateDelta <= 0)
        {
            CurrentGun.Fire();
            fireRateDelta = fireRate;
        }

        //CurrentGun.Fire();
    }

    /// <summary>
    /// / Range where the bullet can fire
    /// </summary>
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, TurretRange);
    }
}
