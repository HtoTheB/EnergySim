using UnityEngine;
using System.Collections;

public class MapMovementScript : MonoBehaviour {

    public Vector3 deltaMouse, lastMouse;
    public float stretchFactor = 15;
    Camera camera;

	// Use this for initialization
	void Start () {
        camera = GameObject.Find("Main Camera").GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {

        #region MoveMap
        //Startposition bei Drücken der Maustaste
        if (Input.GetMouseButtonDown(0))
        {
            lastMouse = Input.mousePosition;
        }
        //Umrechnung von Pixeln und Koordinaten
        if (Input.GetMouseButton(0))
        {
            deltaMouse = lastMouse - Input.mousePosition;

            transform.position-= new Vector3 (camera.ScreenToWorldPoint(new Vector3((Screen.width/2) + deltaMouse.x, (Screen.height/2) + deltaMouse.y, 0)).x, camera.ScreenToWorldPoint(new Vector3((Screen.width/2) + deltaMouse.x, (Screen.height/2) + deltaMouse.y, 0)).y,0);

            lastMouse = Input.mousePosition;
        }
        #endregion
    }
}