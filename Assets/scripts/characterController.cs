using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
     public Camera cam;
    public float x;
    public float sensi;
    public Rigidbody rb;
    public float speed = 25;
 public float gravity = -5;
 
 float velocityY = 0; 
 
 
    // Start is called before the first frame update
    void Start()
    {
           rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
         velocityY += gravity * Time.deltaTime;
 
     Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
     input = input.normalized;
 
     Vector3 temp = Vector3.zero;
     if (input.z == 1)
     {
         temp += transform.forward;
     }
     else if (input.z == -1)
     {
         temp += transform.forward * -1;
     }
 
     if (input.x == 1)
     {
         temp += transform.right;
     }
     else if (input.x == -1)
     {
         temp += transform.right * -1;
     }
 
     Vector3 velocity = temp * speed;
     velocity.y = velocityY;
     
     rb.AddForce(velocity * Time.deltaTime);
 
     
 
     
        Cursor.lockState = CursorLockMode.Locked;
        x += Input.GetAxis("Mouse X")*sensi;
        cam.transform.eulerAngles = new Vector3(0,x,0);
    }
}
