using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenConfig : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setVideoMode(int valueScreen)
    {
        if (valueScreen == 0)
        {
            Screen.fullScreen = !Screen.fullScreen;
        } else if (valueScreen == 1)
        {

            Screen.fullScreen = Screen.fullScreen;
        }
    }
}
