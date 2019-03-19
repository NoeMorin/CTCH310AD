using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletprototyping : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletspawn;
    public AudioClip pewpew;

    private AudioSource source;
    private float volLowRange = 0.5f;
    private float volHighRange = 1.0f;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        //ties 'gun' to camera
        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }
    void Fire()
    {

        Pew();
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

    //shot sound
    void Pew()
    {
        float vol = Random.Range(volLowRange, volHighRange);
        source.PlayOneShot(pewpew, vol);

    }
}
