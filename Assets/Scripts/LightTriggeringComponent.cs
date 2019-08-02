using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTriggeringComponent : MonoBehaviour
{
    public GameObject lightBulb = null;
    
    void OnTriggerEnter (Collider newObject)
    {
        if (newObject.name == "Player")
        {
            lightBulb.SetActive(true);
        }
    }

    void OnTriggerExit(Collider newObject)
    {
        if (newObject.name == "Player")
        {
            lightBulb.SetActive(false);
        }
    }
}
