using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public int speed = 50;
    public int rotateSpeed = 10;
    public bool inFirstPerson = false;
    public float smooth = 2.0F;
    public float tiltAngle = 30.0F;

    // Use this for initialization
    void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!inFirstPerson)
        {
            //TODO: y axis feels weird
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                var rotation = Quaternion.Euler(0, rotateSpeed, 0);
                transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * smooth);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                var rotation = Quaternion.Euler(0, -rotateSpeed, 0);
                transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * smooth);
            }
        }
    }
}
