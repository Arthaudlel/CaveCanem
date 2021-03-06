﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextInput : MonoBehaviour
{
    InputField input;
    InputField.SubmitEvent se;
    public Text output;
    static public GameObject PhotoInterface;

    void Start()
    {
        PhotoInterface = GameObject.Find("PhotoManip");
        PhotoInterface.SetActive(false);
        input = gameObject.GetComponent<InputField>();
        se = new InputField.SubmitEvent();
        se.AddListener(SubmitInput);
        input.onEndEdit = se;
        output.text = "Challenge " + (MyComponentManager.ChallengeLevel - 1);
    }

    private void SubmitInput(string arg0)
    {
        string currentText = output.text.ToString();
        string myresponse = InputHandler.TextHandler(arg0);
        string newText = currentText + "\n" + arg0 + "\n" + myresponse;
        output.text = newText;
        input.text = "";
        input.ActivateInputField();
    }
}
