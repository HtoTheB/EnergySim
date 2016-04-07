using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class Windkraftwerk : WorldObject {



   

    // Use this for initialization
    void Start () {
        setProduction();
	}

    
	// Update is called once per frame
	void Update () {
	
	}

    protected override void setProduction()
    {
        prodElectricity = 5;
        Debug.Log("set");
    }

    protected override void sendInformationsTo(WorldObjectPanelScript receiverscript)
    {
        receiverscript.setOwner(this);
        receiverscript.setInformations("Windkraftwerk", this.prodElectricity, "MW", "WindkraftwerkMinigame");
    }
}
