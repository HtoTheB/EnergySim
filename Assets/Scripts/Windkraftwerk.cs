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
        this.infos.level = 1;
        this.infos.name = "Windkraftwerk";        
        this.infos.production.Add("electricity",new Resource("electricity", 10, "MW"));
        this.infos.production.Add("food",new Resource("food", 20, "Tons"));
    }

    
}
