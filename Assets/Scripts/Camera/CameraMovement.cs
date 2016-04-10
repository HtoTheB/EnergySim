using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class CameraMovement : MonoBehaviour {

    private Vector3 lastMouse, deltaMouse;
    public float stretchFactorX, stretchFactorY, rotationFactorHorizontal, rotationFactorVertical;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //Moving the Camera
        if (Input.GetMouseButtonDown(0))
        {
            lastMouse = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            Debug.Log(transform.eulerAngles);

            deltaMouse = lastMouse - Input.mousePosition;

            transform.localPosition += (new Vector3(
                MyMath.degCos(transform.eulerAngles.y) * stretchFactorX * deltaMouse.x + MyMath.degSin(transform.eulerAngles.y) * stretchFactorY * deltaMouse.y, 0,
                MyMath.degCos(transform.eulerAngles.y) * stretchFactorY * deltaMouse.y - MyMath.degSin(transform.eulerAngles.y) * stretchFactorX * deltaMouse.x));

            lastMouse = Input.mousePosition;
        }

        //Rotating the Camera
        if (Input.GetMouseButtonDown(1))
        {
            lastMouse = Input.mousePosition;
        }
        if (Input.GetMouseButton(1))
        {
            deltaMouse = lastMouse - Input.mousePosition;

            transform.eulerAngles -= (new Vector3(-rotationFactorVertical * deltaMouse.y, rotationFactorHorizontal * deltaMouse.x, 0));

            lastMouse = Input.mousePosition;
        }
    }
}
