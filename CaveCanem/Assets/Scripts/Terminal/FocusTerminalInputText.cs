﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FocusTerminalInputText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventSystem.current.SetSelectedGameObject(this.gameObject, null);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
