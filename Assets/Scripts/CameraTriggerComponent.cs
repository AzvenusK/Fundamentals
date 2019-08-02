using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTriggerComponent : MonoBehaviour
{
    public CameraComponennt camera_2;
    public CameraComponennt.CameraState cameraState;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            camera_2.cameraState = cameraState;
        }
    }

}
