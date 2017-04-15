using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTowerScript : MonoBehaviour
{

    public bool inFirstPersonView = false;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetKeyDown("space"))
	    {
	        ToggleCamera();
	    }
    }

    public void ToggleCamera()
    {
        inFirstPersonView = !inFirstPersonView ? true : false;

        if (inFirstPersonView)
        {
            //TODO zoom in
        }s
        else
        {
            //TODO zoom out
        }
    }
}
