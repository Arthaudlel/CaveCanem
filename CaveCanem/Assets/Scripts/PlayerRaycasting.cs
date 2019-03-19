﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerRaycasting : MonoBehaviour {

    public float distanceToSee;
    RaycastHit whatIHit;
    GameObject InformationUi;
    bool IsPaused = false;

	// Use this for initialization
	void Start () {
        InformationUi = GameObject.Find("MyInformationsPaper");
        InformationUi.SetActive(false);
        GameObject Camera = GameObject.Find("MainCamera");
        MyComponentManager.ChallengeLevel = SceneManager.GetActiveScene().buildIndex;
        //MyComponentManager.Success = false;
        Debug.Log(MyComponentManager.ChallengeLevel);
    }

    // Update is called once per frame
    void Update () {
        Debug.DrawRay(this.transform.position, this.transform.forward * distanceToSee, Color.yellow);
        if (MyComponentManager.Success == true)
        {
            GameObject.Find("Door").GetComponent<OpeningDoor>().opening = true;
        }
        if (Physics.Raycast(this.transform.position, this.transform.forward, out whatIHit, distanceToSee))
        {
            //Debug.Log("Itouched something" + whatIHit.collider.gameObject.name);
            if (whatIHit.collider.tag == "Door") {
                if (Input.GetKeyDown(KeyCode.Keypad0))
                {
                    whatIHit.collider.gameObject.GetComponent<OpeningDoor>().opening = true;
                }
            }
            if (whatIHit.collider.gameObject.name == "Laptop")
            {
                GameObject.Find("InteractionText").GetComponent<Text>().text = "Press E to Use";
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("interacting with " + whatIHit.collider.gameObject.name);
                    //Scene terminalScene = SceneManager.GetSceneAt(1); le nombre un marche pas
                    SceneManager.LoadScene(1);
                }
            }
            else if (whatIHit.collider.tag == "InformationsPaper")
            {
                if (InformationUi.activeSelf)
                {
                    GameObject.Find("InteractionText").GetComponent<Text>().text = "Press 0 to Exit";
                } else {
                    GameObject.Find("InteractionText").GetComponent<Text>().text = "Press 0 to Read";
                }
                if (Input.GetKeyDown(KeyCode.Keypad0) && !InformationUi.activeSelf)
                {
                    InformationUi.SetActive(true);
                    this.GetComponent<camMouseLook>().sensitivity = 0f;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad0) && InformationUi.activeSelf)
                {
                    this.GetComponent<camMouseLook>().sensitivity = 3f;
                    InformationUi.SetActive(false);
                }
            }
            else
            {
                GameObject.Find("InteractionText").GetComponent<Text>().text = "";
            }
        }
        else
        {
            GameObject.Find("InteractionText").GetComponent<Text>().text = "";
        }
    }
}
