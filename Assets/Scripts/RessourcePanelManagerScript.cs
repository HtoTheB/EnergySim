using UnityEngine;
using System.Collections;

public class RessourcePanelManagerScript : MonoBehaviour {

    private int ressourceAmount = 4;
    private string[] resNames = { "resMoney", "resElectricity", "resWorkforce", "resFood" };
    public GameObject RessourcePanelPrefab;

	// Use this for initialization
	void Start () {
	    for (int i = 0; i < ressourceAmount; i++)
        {
            Instantiate(RessourcePanelPrefab,new Vector3(90+ i*170,-25,0),Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    GameMasterScript gameMaster { get {return GameObject.Find("GameMaster").GetComponent<GameMasterScript>(); } }
}