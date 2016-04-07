using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class RessourcePanelManagerScript : MonoBehaviour
{

    public GameObject RessourcePanelPrefab;

    private int resourceAmount = 4;
    private Text[] panelArray = new Text[4];

    // Use this for initialization
    void Start()
    {
        
        for (int i = 0; i < resourceAmount; i++)
        {

            panelArray = this.gameObject.GetComponentsInChildren<Text>(); // Reference no value!
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        // Displaying the Amounts calculated by GameMasterScript. Rounding them to int
        panelArray[0].text = ((int)System.Math.Round(GameMasterScript.instance.resMoney)).ToString();
        panelArray[1].text = ((int)System.Math.Round(GameMasterScript.instance.resElectricity)).ToString();
        panelArray[2].text = ((int)System.Math.Round(GameMasterScript.instance.resWorkforce)).ToString();
        panelArray[3].text = ((int)System.Math.Round(GameMasterScript.instance.resFood)).ToString();
        
    }

}

