using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public class movement : MonoBehaviour
{
    /// Normal speed of camera movement.
    public float movementSpeed = 10f;

    /// Speed of camera movement when shift is held down,
    public float fastMovementSpeed = 100f;

    /// Amount to zoom the camera when using the mouse wheel.
    public float zoomSensitivity = 10f;

    /// Amount to zoom the camera when using the mouse wheel (fast mode).
    public float fastZoomSensitivity = 50f;

 

    void Update()
    {
       
        var movementSpeed = this.movementSpeed;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position + (-transform.right * movementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + (transform.right * movementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = transform.position + (transform.forward * movementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = transform.position + (-transform.forward * movementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = transform.position + (transform.up * movementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position = transform.position + (-transform.up * movementSpeed * Time.deltaTime);
        }



        float axis = Input.GetAxis("Mouse ScrollWheel");
        if (axis != 0)
        {
            var zoomSensitivity =  this.zoomSensitivity;
            transform.position = transform.position + transform.forward * axis * zoomSensitivity;
        }

   
   
    }
}
