using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slot1 : MonoBehaviour
{
    private GameScript mainScript;
    int selected = 0;

    public void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
        {
            mainScript = GameObject.Find("GameScript").GetComponent<GameScript>();
            mainScript.CreateTower(selected);
        }
    }
}
