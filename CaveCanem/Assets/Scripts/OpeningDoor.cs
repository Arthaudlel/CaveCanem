using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningDoor : MonoBehaviour {
    public bool opening = false;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        //yPosition = this.transform.position.y;

        if (opening)
        {
            while (this.transform.position.y < 10)
            {
                this.transform.Translate(Vector3.up * Time.deltaTime, Space.World);
            }
        }
    }
}
