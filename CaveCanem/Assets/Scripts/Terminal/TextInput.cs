using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInput : MonoBehaviour
{
    InputField input;
    InputField.SubmitEvent se;
    public Text output;

    void Start()
    {
        input = gameObject.GetComponent<InputField>();
        se = new InputField.SubmitEvent();
        se.AddListener(SubmitInput);
        input.onEndEdit = se;
    }

    private void SubmitInput(string arg0)
    {
        string currentText = output.text.ToString();
        string newText = currentText + "\n" + arg0;
        output.text = newText;
        input.text = "";
        input.ActivateInputField();
    }
}
