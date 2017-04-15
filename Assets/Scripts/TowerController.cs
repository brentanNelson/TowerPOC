using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour
{

	// Use this for initialization
    public bool inFirstPersonView = false;
    private Rigidbody rigidBody;
    private CameraController mainCam;
    private Vector3 camCurrentPosition;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        var findCamera = GameObject.Find("Main Camera");
        mainCam = findCamera.GetComponent<CameraController>();
    }

    // Update is called once per frame
    void Update()
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
            //zoom in
            mainCam.inFirstPerson = true;
            camCurrentPosition = Camera.main.transform.position;
            Camera.main.transform.position = rigidBody.transform.position;
        }
        else
        {
            //zoom out
            mainCam.inFirstPerson = false;
            Camera.main.transform.position = camCurrentPosition;
        }
    }
}
