using UnityEngine;
using System.Collections;

public class CameraScroll : MonoBehaviour {

    public float maxZoom = 7;
    public float minZoom = 2;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        GetComponent<Camera>().orthographicSize -= Input.GetAxis("Mouse ScrollWheel");
        if (GetComponent<Camera>().orthographicSize > maxZoom) GetComponent<Camera>().orthographicSize = maxZoom;
        else if (GetComponent<Camera>().orthographicSize < minZoom) GetComponent<Camera>().orthographicSize = minZoom;
    }
}
