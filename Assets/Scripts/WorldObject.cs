using UnityEngine;
using System.Collections;

public abstract class WorldObject : MonoBehaviour
{
    void OnMouseDown()
    {   
        OpenInfoScreen();
    }

    protected abstract void OpenInfoScreen();

}
