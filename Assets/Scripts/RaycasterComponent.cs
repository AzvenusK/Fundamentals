using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycasterComponent : MonoBehaviour
{
    public Camera camera1;
    public GameObject obj;
    public Ray ray;
    public Transform origin;
    public float rayLength = 2.0f;
    public RaycastHit hit;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //ray = camera1.ScreenPointToRay(Input.mousePosition);
            //ScreenPointToRay is a 2D ray and ignores the z-axis
            //if (Physics.Raycast(ray) ) //Single Raycast will stop where it hits or collides the first rigid object 
            //{
            //  Debug.Log("Hit an object.");
            //}

            /* if (Physics.Raycast(ray, out hit))
             {
                 if (hit.collider)
                 {
                     Debug.Log("Hit the object : "+hit.collider.name);

                     Instantiate(obj, hit.point, hit.transform.rotation);
                 }
             }*/

            /* RaycastHit[] hits = null;
                hits = Physics.RaycastAll(ray);
                if (hits.Length > 0)
                {
                    for (int i = 0; i < hits.Length; i++)
                    {
                        RaycastHit hitt = hits[i];
                        Debug.Log("Hit the objects : "+hitt.collider.name);

                    }
                }
                */
            RaycastHit[] hits = null;
            hits = Physics.RaycastAll(origin.position, Vector3.forward, rayLength);

            if (hits.Length > 0)
            {
                for (int i = 0; i < hits.Length; i++)
                {
                    if (hits[i].collider)
                    {
                        Debug.Log("We hit the "+hits[i].collider.name);
                    }
                }
            }
            Debug.DrawRay(origin.position, Vector3.forward * rayLength, Color.green, 2);
        }
        //Debug.DrawLine(ray.origin, hit.point, Color.red);
       
    }
}
