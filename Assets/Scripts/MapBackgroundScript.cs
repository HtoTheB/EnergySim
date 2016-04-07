using UnityEngine;
using System.Collections;

public class MapBackgroundScript : MonoBehaviour {

    public Vector3 deltaMouse, lastMouse;
    public float stretchFactor = 15;
    Camera camera;

	// Use this for initialization
	void Start () {
        camera = GameObject.Find("Main Camera").GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetMouseButtonDown(1))
        {
            lastMouse = Input.mousePosition;
            Debug.Log("Mouse down: "+ Input.mousePosition);
        }
        if (Input.GetMouseButton(1))
        {
            deltaMouse = lastMouse - Input.mousePosition;

            transform.position-= new Vector3 (camera.ScreenToWorldPoint(new Vector3((Screen.width/2) + deltaMouse.x, (Screen.height/2) + deltaMouse.y, 0)).x, camera.ScreenToWorldPoint(new Vector3((Screen.width/2) + deltaMouse.x, (Screen.height/2) + deltaMouse.y, 0)).y,0);

            Debug.Log(new Vector3(camera.ScreenToWorldPoint(new Vector3((Screen.width/2) + deltaMouse.x, (Screen.height/2) + deltaMouse.y, 0)).x, camera.ScreenToWorldPoint(new Vector3((Screen.width/2) + deltaMouse.x, (Screen.height/2) + deltaMouse.y, 0)).y, 0));

            lastMouse = Input.mousePosition;
        }
	}
}