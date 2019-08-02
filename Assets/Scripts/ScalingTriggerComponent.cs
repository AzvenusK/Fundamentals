using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalingTriggerComponent : MonoBehaviour
{
    public GameObject wall = null;
    public float scaleAmount = 3.0f;
    public Vector3 originalScale = Vector3.zero;

    private void Awake()
    {
        originalScale = this.transform.localScale;
    }

    private void OnTriggerEnter(Collider newObject)
    {
        if (newObject.name == "Player")
        {
            wall.GetComponent<ScalingComponent>().EnableScale();

        }
    }

    private void OnTriggerExit(Collider newObject)
    {
        if (newObject.name == "Player")
        {
            wall.GetComponent<ScalingComponent>().DisableScale();

        }
    }

   
}
