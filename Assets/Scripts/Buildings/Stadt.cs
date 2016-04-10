using UnityEngine;
using System.Collections;
using System;

public class Stadt : WorldObject {

    protected override void setProduction()
    {
        this.infos.level = 1;
        this.infos.name = "Stadt";
        this.infos.production.Add("food",new Resource("food", 10, "Tons"));
    }

    // Use this for initialization
    void Start () {
        setProduction();
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
