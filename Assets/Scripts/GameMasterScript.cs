using UnityEngine;
using System.Collections;

public class GameMasterScript : MonoBehaviour {

    //Main ressources of the game
    public int res_money, res_electricity, res_workforce, res_food;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



    //Time in seconds since the app was opened last
    public int lastDowntime { get
        {
            return 0;
        }
    }
}
