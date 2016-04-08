using UnityEngine;
using System.Collections;

public class MapMovementScript : MonoBehaviour {

    public Vector3 deltaMouse, lastMouse;
    public float stretchFactorX;
    public float stretchFactorY;
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

	    if (Input.GetMouseButtonDown(0))
        {
            lastMouse = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            deltaMouse = lastMouse - Input.mousePosition;

            transform.position -= (new Vector3(stretchFactorX * deltaMouse.x, 0,stretchFactorY * deltaMouse.y));

            lastMouse = Input.mousePosition;
        }
        #endregion
    }
}