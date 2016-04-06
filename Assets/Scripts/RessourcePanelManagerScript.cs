using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class RessourcePanelManagerScript : MonoBehaviour
{

    public GameObject RessourcePanelPrefab;

    private int ressourceAmount = 4;
    private GameObject[] panelArray = new GameObject[4];

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < ressourceAmount; i++)
        {
            GameObject tempObject = Instantiate(RessourcePanelPrefab);
            tempObject.transform.parent = this.transform;
            tempObject.transform.localPosition = new Vector3(90 + i * 190, -25, 0);
            tempObject.transform.localScale = new Vector3(1, 1, 1);
            panelArray[i] = tempObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        panelArray[0].GetComponentInChildren<Text>().text = gameMaster.resMoney.ToString();
        panelArray[1].GetComponentInChildren<Text>().text = gameMaster.resElectricity.ToString();
        panelArray[2].GetComponentInChildren<Text>().text = gameMaster.resWorkforce.ToString();
        panelArray[3].GetComponentInChildren<Text>().text = gameMaster.resFood.ToString();
    }

    GameMasterScript gameMaster { get { return GameObject.Find("GameMaster").GetComponent<GameMasterScript>(); } }
}

