using UnityEngine;
using System.Collections;

public abstract class WorldObject : MonoBehaviour
{
    public float prodMoney, prodElectricity, prodWorkforce, prodFood;
    protected bool panelopen = false;





    void OnMouseDown()
    {
        OpenInfoScreen();
    }
    /// <summary>
    /// Gets Invoked by spawned Panel when Info Screen is closed
    /// </summary>
    public void CloseInfoScreen()
    {
        panelopen = false;
    }

    /// <summary>
    /// Gets called when the WorldObject is clicked on
    /// </summary>
    protected void OpenInfoScreen()
    {
        if (!panelopen)
        {
            GameObject panel = (GameObject)Instantiate(GameMasterScript.instance.worldObjectPanel, this.transform.position, Quaternion.identity);
            panel.transform.SetParent(GameObject.Find("Canvas").transform);
            panel.transform.localScale = new Vector3(1, 1, 1);
            panel.SetActive(true);



            panelopen = true;
            this.sendInformationsTo(panel.GetComponent<WorldObjectPanelScript>());
        }
    }

    protected abstract void sendInformationsTo(WorldObjectPanelScript receiverscript);

    protected abstract void setProduction();

}
