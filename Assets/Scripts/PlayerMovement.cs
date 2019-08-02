using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float translationSpeed = 5.0f;
    public float rotationSpeed = 4.0f;
    public bool canMoveSideways = false;
    private void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Pressed Up Arrow");

            this.transform.Translate(new Vector3(0, 0, translationSpeed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Pressed Down Arrow");

            this.transform.Translate(new Vector3(0, 0, -translationSpeed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (canMoveSideways)
            {
                Debug.Log("Pressed Right Arrow");

                this.transform.Translate(new Vector3(translationSpeed * Time.deltaTime, 0, 0));
            }

            else
            {
               
                Debug.Log("Pressed Right Arrow");

                this.transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));
               
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (canMoveSideways)
            {
                Debug.Log("Pressed Left Arrow");

                this.transform.Translate(new Vector3(-translationSpeed * Time.deltaTime, 0, 0));
            }

            else
            {
                Debug.Log("Pressed Left Arrow");

                this.transform.Rotate(new Vector3(0, -rotationSpeed * Time.deltaTime, 0));
            }
        }

        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Pressed W");

            this.transform.Translate(new Vector3(0, translationSpeed * Time.deltaTime, 0));
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Pressed S");

            this.transform.Translate(new Vector3(0, -translationSpeed * Time.deltaTime, 0));
        }

    }
}
