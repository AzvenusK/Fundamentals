using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraComponennt : MonoBehaviour
{
    public Transform player = null;
    public Transform target = null;
    //public float speed = 5.0f;
    public Vector3 speed = new Vector3(4.0f,2.0f,1.0f);
    public Vector3 nextPosition = Vector3.zero;
    public enum CameraState { none, FollowPosition, LoookAtPlayer,  both};
    public CameraState cameraState = CameraState.none;
    private void LateUpdate()
    {/*
        switch (cameraState)
        {
            case CameraState.none:
                break;
            case CameraState.FollowPosition:
                FollowPosition();
                break;
            case CameraState.LoookAtPlayer:
                LookAtPlayer();
                break;
            case CameraState.both:
                FollowPosition();
                LookAtPlayer();
                break;

        }*/
        LookAtPlayer();
        FollowPosition();
              
    }

    void  FollowPosition()
    {
        nextPosition.x = Mathf.Lerp(this.transform.position.x, target.position.x, speed.x * Time.deltaTime);
        nextPosition.y = Mathf.Lerp(this.transform.position.y, target.position.y, speed.y * Time.deltaTime);
        nextPosition.z = Mathf.Lerp(this.transform.position.z, target.position.z, speed.z * Time.deltaTime);
        this.transform.position = nextPosition;
        //this.transform.position = target.position;
    }

    void LookAtPlayer()
    {
        this.transform.LookAt(player.position);
    }

}
