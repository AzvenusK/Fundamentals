using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndMoveComponent : MonoBehaviour
{
    public Camera camera1;
    public Transform player;
    public Vector3 moveToPosition;
    public float speed = 5.0f;
    private RaycastHit hit;
    private Ray ray;

    private void Update()
    {
       // if (Input.GetMouseButtonDown (0)) 
       //By commenting this out you are removing the condition of mouseclick so the player follows the position of the mouse.
        //{
            ray = camera1.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast (ray, out hit))
            {
                if (hit.collider.name == "Plane")
                {
                    moveToPosition = hit.point;
                }
            }
        //}

        player.transform.position = Vector3.Lerp(player.transform.position, moveToPosition, speed * Time.deltaTime);
    }
}
