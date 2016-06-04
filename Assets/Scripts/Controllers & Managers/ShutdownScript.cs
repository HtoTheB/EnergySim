using UnityEngine;
using System.Collections;

public class ShutdownScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Shutdown()
    {
        Debug.Log("Shutting down");
        Application.Quit();
    }
}
