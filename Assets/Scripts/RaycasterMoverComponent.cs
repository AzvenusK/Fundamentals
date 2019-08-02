using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycasterMoverComponent : MonoBehaviour
{
    public Camera camera1;
    private Ray ray;
    private RaycastHit hit;
    private GameObject hitObject = null;


    private void Update()
    {
        if (Input.GetMouseButtonDown (0))
        {
            ray = camera1.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast (ray, out hit))
            {
                if (hit.collider.name == "Cube")
                {
                    hitObject = hit.collider.gameObject;
                }
            }
        }

        if (hitObject)
        {
            //hold object, note its GetMouseButton here and not GetMouseButto Down
            if (Input.GetMouseButton(0))
            {
                ray = camera1.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast (ray, out hit))
                {
                    hitObject.transform.position = new Vector3(hit.point.x, hitObject.transform.position.y, hit.point.z);

                }
            }

            //drop object
            if (Input.GetMouseButtonUp(0))
            {
                hitObject = null;
            }
        }
    }
}
