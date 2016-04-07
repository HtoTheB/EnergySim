using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WorldObjectPanelScript : MonoBehaviour
{
    private WorldObject owner;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Informations from parent WorldObject(Windkraftwerk, Stadt etc.)
    public void setOwner(WorldObject owner)
    {
        this.owner = owner;
    }

    public void setInformations(string WOName, float WOProduction, string prodUnit, string WOMinigameName)
    {
        transform.Find("NameText").gameObject.GetComponent<Text>().text = WOName;
        transform.Find("ProductionText").gameObject.GetComponent<Text>().text = WOProduction.ToString() + " " + prodUnit;
    }

    // Button Listner
    public void CancelClicked()
    {
        owner.CloseInfoScreen();
        Destroy(gameObject);
    }

    public void MinigameClicked()
    {
    }

   
}
