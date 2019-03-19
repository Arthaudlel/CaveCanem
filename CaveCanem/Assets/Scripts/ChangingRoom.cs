using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangingRoom : MonoBehaviour
{
    int activeScene;
    public void LoadSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    void Update()
    {
        if(this.transform.position.z >= 25)
        {
            if (Cursor.lockState == CursorLockMode.Locked)
            {
                Cursor.lockState = CursorLockMode.None;
            }
            MyComponentManager.Success = false;
            activeScene = SceneManager.GetActiveScene().buildIndex;
            LoadSceneByIndex(activeScene + 1);
        }
    }
}
