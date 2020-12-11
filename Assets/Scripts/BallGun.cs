using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGun : MonoBehaviour
{
    public GameObject ballPrefab = null;
    public float projectileSpeed = 20f;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject projectile = Instantiate(ballPrefab, transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>().velocity = transform.forward * projectileSpeed;
            Destroy(projectile, 10f);
        }
    }
}
