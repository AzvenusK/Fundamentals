using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoringComponent : MonoBehaviour
{
    public Color newColor = Color.white;
    public Color originalColor = Color.white;

    private void Awake()
    {
        originalColor = this.GetComponent<Renderer>().material.color;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            EnableColor(); 
        }

        else if (Input.GetKeyUp(KeyCode.G))
        {
            DisableColor();
        }
    }
    public void EnableColor()
    {
        this.GetComponent<Renderer>().material.color = newColor;
    }

    public void DisableColor()
    {
        this.GetComponent<Renderer>().material.color = originalColor;
    }
}
