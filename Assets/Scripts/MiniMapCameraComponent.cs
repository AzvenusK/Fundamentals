using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapCameraComponent : MonoBehaviour
{
    public Transform target = null;
    public float cameraHeight = 10.0f;
    public bool followTarget = true;

    private void LateUpdate()
    {
        if (followTarget)
        {
            this.transform.position = new Vector3(target.position.x,cameraHeight,target.position.z);            
        }
        else
        {
            this.transform.position = new Vector3(this.transform.position.x, cameraHeight, this.transform.position.z);
        }
    }



}
