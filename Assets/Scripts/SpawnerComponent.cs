using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerComponent : MonoBehaviour
{
    public GameObject spawnNew = null;
    public float minScale = 1.0f;
    public float maxScale = 10.0f;
    public float force = 100.0f;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject obj = Instantiate(spawnNew) as GameObject;

            
            obj.transform.position = this.transform.position;
            obj.AddComponent<Rigidbody>();
            obj.name = "newSphere";

            float scaleSize = Random.Range(minScale,maxScale);
            obj.transform.localScale = Vector3.one * scaleSize;

            obj.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, force, 0));
        }
    }

}
