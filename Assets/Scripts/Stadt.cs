using UnityEngine;
using System.Collections;
using System;

public class Stadt : WorldObject {
    protected override void sendInformationsTo(WorldObjectPanelScript receiverscript)
    {
        receiverscript.setOwner(this);
        receiverscript.setInformations("Stadt", this.prodMoney, "Euro", "StadtMinigame");
    }

    protected override void setProduction()
    {
        prodMoney = 10;
    }

    // Use this for initialization
    void Start () {
        setProduction();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
