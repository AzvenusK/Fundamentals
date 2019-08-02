using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorTriggerComponent : MonoBehaviour
{
    public GameObject wall = null;


    private void OnTriggerEnter(Collider newObject)
    {
        if (newObject.name == "Player")
        {
            wall.GetComponent<ColoringComponent>().EnableColor();

        }
    }

    private void OnTriggerExit(Collider newObject)
    {
        if (newObject.name == "Player")
        {
            wall.GetComponent<ColoringComponent>().DisableColor();

        }
    }



}
