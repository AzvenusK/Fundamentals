using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalingComponent : MonoBehaviour
{
    public float scaleAmount = 3.0f;
    public Vector3 originalScale = Vector3.zero; 

    private void Awake()
    {
        originalScale = this.transform.localScale;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log("Pressed G");

            EnableScale();
            
        }

        else if (Input.GetKeyUp(KeyCode.G))
        {
            DisableScale();
        }
    }

    public void EnableScale()
    {
        this.transform.localScale = Vector3.one * scaleAmount;
        //Same as writing : 
        //this.transform.localScale = new Vector3 (scaleAmount, scaleAMount, scaleAmount); 
    }

    public void DisableScale()
    {
        this.transform.localScale = originalScale;
    }

}
