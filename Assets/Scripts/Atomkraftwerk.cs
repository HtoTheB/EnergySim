using UnityEngine;
using System.Collections;
using System;

public class Atomkraftwerk : WorldObject {

    protected override void sendInformationsTo(WorldObjectPanelScript receiverscript)
    {
        receiverscript.setOwner(this);
        receiverscript.setInformations("Atomkraftwerk", this.prodElectricity, "MW", "AtomkraftwerkMinigame");
    }

    protected override void setProduction()
    {
        prodElectricity = 10;
    }

    // Use this for initialization
    void Start () {
        setProduction();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
