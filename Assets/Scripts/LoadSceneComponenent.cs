using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneComponenent : MonoBehaviour
{
    public int loadScene = 0;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene(loadScene);
        }
    }
}
