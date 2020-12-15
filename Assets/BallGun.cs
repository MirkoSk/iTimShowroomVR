using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGun : MonoBehaviour
{
    public GameObject ball = null;
    public float projectileSpeed = 20f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject projectile = Instantiate(ball, transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody>().velocity = transform.forward * projectileSpeed;
            Destroy(projectile, 10f);
        }
    }
}
