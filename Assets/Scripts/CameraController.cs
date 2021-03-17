using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public Transform[] views;
	public float transitionSpeed;
	Transform currentview;
	public Camera myCamera;
	public float timer;

	// Use this for initialization
	void Start () {

		myCamera = transform.GetComponent<Camera>();
	}

	void Update()
	{
		if (timer < 500)
		{
			timer++;
		}
		if(timer == 50)
		{
			currentview = views[0];
			float cameraZoom = 4f;

			myCamera.orthographicSize = cameraZoom;
		}
		if (timer >= 150)
		{
			currentview = views[1];

			myCamera.orthographicSize = 15f;
		}

	}
	
	// Update is called once per frame
	void LateUpdate () {
        if(timer < 500)
        {
            transform.position = Vector3.Lerp(transform.position, currentview.position, Time.deltaTime * transitionSpeed);
        }
		
	}
}
