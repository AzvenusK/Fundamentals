using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickComponent : MonoBehaviour
{
    private Color originalColor = Color.white;
    private void Awake()
    {
        originalColor = this.GetComponent<Renderer>().material.color;
    }
    private void OnMouseEnter()
    {
        this.transform.GetComponent<Renderer>().material.color = Color.magenta; 
    }

    private void OnMouseExit()
    {
        this.transform.GetComponent<Renderer>().material.color = originalColor;
    }
}
