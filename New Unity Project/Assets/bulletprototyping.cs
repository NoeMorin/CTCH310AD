using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletprototyping : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletspawn;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Verical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }
    void Fire()
    {
        //Creating bullet from bullet prefab
        var newBullet = (GameObject)Instantiate(
            bullet,
            bulletspawn.position,
            bulletspawn.rotation);

        //Add Velocity
        newBullet.GetComponent<Rigidbody>().velocity = newBullet.transform.forward * 60;

        //Destroy the bullet after 2 seconds
        Destroy(newBullet, 2.0f);

    }
}
