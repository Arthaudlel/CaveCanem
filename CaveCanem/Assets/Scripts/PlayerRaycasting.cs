using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerRaycasting : MonoBehaviour {

    public float distanceToSee;
    RaycastHit whatIHit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.DrawRay(this.transform.position, this.transform.forward * distanceToSee, Color.yellow);
        if (Physics.Raycast(this.transform.position, this.transform.forward, out whatIHit, distanceToSee))
        {
            if (whatIHit.collider.gameObject.name == "Laptop")
            {
                GameObject.Find("InteractionText").GetComponent<Text>().text = "Press E to Use";
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("interacting with " + whatIHit.collider.gameObject.name);
                    SceneManager.LoadScene(2);
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
