using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManipulateImage : MonoBehaviour
{
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setAlpha(float sliderValue)
    {
        image = GetComponent<Image>();
        var tmpColor = image.color;
        tmpColor.a = sliderValue;
        image.color = tmpColor;
    }
}
