using UnityEngine;
using System.Collections;

public abstract class WorldObject : MonoBehaviour
{
   
    protected bool panelopen = false;

    public WorldObjectInfos infos = new WorldObjectInfos();



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
            GameObject panel = Instantiate(GameMasterScript.instance.worldObjectPanel);
            ((RectTransform)panel.transform).anchoredPosition = new Vector2(0, 0);
            panel.transform.SetParent(GameObject.Find("Canvas").transform,false);
            panel.transform.localScale = new Vector3(1, 1, 1);
            panel.SetActive(true);
            
            panelopen = true;
            panel.GetComponent<WorldObjectPanelScript>().setInformations(infos);
            panel.GetComponent<WorldObjectPanelScript>().setOwner(this);
        }
    }

    


    /// <summary>
    /// Set the start Production
    /// </summary>
    protected abstract void setProduction();

}
