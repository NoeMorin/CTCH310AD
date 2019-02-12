using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        Cursor.lockState = CursorLockMode.Locked;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.z++;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.z--;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }
        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");
        float z = transform.eulerAngles.z;

        transform.Rotate(0, 0, -z);

        transform.Rotate(-v, h, 0);
        //also
        //transform.Rotate(-v,0,0);
        //transform.Rotate(0,h,0);
        //if(this.transform.rotation.eulerAngles.z!= 0)
        //{
        //this.tranform.Rotate(0,0, -This.transform.eulerAngles.z);
        //}
        //MOVEMENT via camera direction
        //transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, Camera.main.transform.localEulerAngles.y, transform.localEulerAngles.z);

    }
}
//fix Z axis; only allow range of movement along X axis
//camera.look where to move(fix arrowkey problem)
//deliver C# code assignment 2
//Submit playthrough proofing copy with Twine or a storyboard in Twine