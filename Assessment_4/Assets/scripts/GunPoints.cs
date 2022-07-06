using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPoints : MonoBehaviour
{

    public float ProjectileSpeed = 5f;

    private void Update()
    {
        transform.Translate(new Vector3(ProjectileSpeed * Time.deltaTime , 0f, 0f ));
    }
}
