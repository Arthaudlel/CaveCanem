using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;


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
            //Debug.Log("Itouched something" + whatIHit.collider.gameObject.name);
            if (whatIHit.collider.tag == "Door")
            {
                GameObject.Find("InteractionText").GetComponent<Text>().text = "Press E to open";
                if (Input.GetKeyDown(KeyCode.E))
                {
                    whatIHit.collider.gameObject.GetComponent<OpeningDoor>().opening = true;
                }
            }
        }
        else
        {
            GameObject.Find("InteractionText").GetComponent<Text>().text = "";
        }
    }
}
