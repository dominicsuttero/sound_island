using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    
    public float mouseSensitivity = 100f;
    public Transform playerBody;

    // Start is called before the first frame update
    void Start()
    {
        // The cursor is locked at the center of the screen and invisible
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // the brown "Mouse X" and "Mouse Y" are the positions of the real mouse. "mouseX" and "mouseY" are the variables. We disconnect it from FrameRate
        var mouseX = Input.GetAxis("Mouse X")* mouseSensitivity * Time.deltaTime;
        
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
