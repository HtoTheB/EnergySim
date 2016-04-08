using UnityEngine;
using System.Collections;

public class CameraScroll : MonoBehaviour {

    public float maxZoom;
    public float minZoom;
    public float zoomFactor;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Camera>().fieldOfView -= zoomFactor * Input.GetAxis("Mouse ScrollWheel");
        if (GetComponent<Camera>().fieldOfView > maxZoom) GetComponent<Camera>().fieldOfView = maxZoom;
        else if (GetComponent<Camera>().fieldOfView < minZoom) GetComponent<Camera>().fieldOfView = minZoom;
    }
}
