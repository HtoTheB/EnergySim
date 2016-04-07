using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class WorldObjectPanelScript : MonoBehaviour
{
    private WorldObject owner; // parent WorldObject(Windkraftwerk, Stadt etc.)

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    
    public void setOwner(WorldObject owner)
    {
        this.owner = owner;
    }

    // Informations from parent WorldObject(Windkraftwerk, Stadt etc.)
    public void setInformations(WorldObjectInfos infos)
    {
        transform.Find("NameLevelText").gameObject.GetComponent<Text>().text = infos.name;

        foreach (DictionaryEntry entry in infos.production)
        {
            transform.Find("ProductionText").gameObject.GetComponent<Text>().text += ((Resource)entry.Value).amount + " " + ((Resource)entry.Value).unit + "\n";
        }

    }

    // Button Listners
    public void CancelClicked()
    {
        owner.CloseInfoScreen();
        Destroy(gameObject);
    }

    public void MinigameClicked()
    {
    }

   
}
