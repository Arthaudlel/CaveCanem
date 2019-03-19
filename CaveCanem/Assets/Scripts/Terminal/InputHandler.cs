using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputHandler : MonoBehaviour
{
    //static int activeScene = MyComponentManager.ChallengeLevel;
    // Start is called before the first frame update

    public static string TextHandler(string str)
    {
        int activeScene = MyComponentManager.ChallengeLevel;
        Debug.Log("Terminal Active Scene : " + activeScene);
        if (str == "Quit" || str == "quit")
        {
            SceneManager.LoadScene(activeScene);
            return "";
        }
        if (activeScene == 2)
        {
            if (str == "pass")
            {
                MyComponentManager.Success = true;
                return "Challenge 1: \n You Gess Right :)";
            }
            return "Challenge 1:";
        }
        else if (activeScene == 3)
        {
            return "Challenge 2:";
        }
        return "";
    }
}
