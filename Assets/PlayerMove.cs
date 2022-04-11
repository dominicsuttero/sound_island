using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    
    public CharacterController controller;
    public float speed = 12f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Define what is horizontal and what is vertical
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // Vector3 is movement in a 3D space
        // local variable "moveDirection" is changed
        var transform1 = transform;
        Vector3 moveDirection = transform1.right * x + transform1.forward * z;

        // add speed and disconnect it from frame rate
        controller.Move(moveDirection * speed * Time.deltaTime);
    }
}
