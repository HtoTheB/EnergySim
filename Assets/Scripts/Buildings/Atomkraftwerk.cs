using UnityEngine;
using System.Collections;
using System;

public class Atomkraftwerk : WorldObject {


    protected override void setProduction()
    {
        this.infos.level = 1;
        this.infos.name = "Atomkraftwerk";
        this.infos.production.Add("electricity",new Resource("electricity", 100, "MW"));
    }

    // Use this for initialization
    void Start () {
        setProduction();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
