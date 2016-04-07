using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class Windkraftwerk : WorldObject {

    bool panelopen = false;
    public GameObject worldObjectPanel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    protected override void OpenInfoScreen()
    {
        if(!panelopen)
        {
            GameObject panel = (GameObject)Instantiate(worldObjectPanel,this.transform.position,Quaternion.identity);
            panel.transform.SetParent(GameObject.Find("Canvas").transform);
            panel.transform.localScale = new Vector3(1, 1, 1);
            panel.SetActive(true);
            panelopen = true;
            Debug.Log("Opened WK Panel");
        }
    }
}
