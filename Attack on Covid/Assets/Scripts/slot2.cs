using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slot2 : MonoBehaviour
{
    private GameScript mainScript;
    int selected = 1;

    public void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
        {
            mainScript = GameObject.Find("GameScript").GetComponent<GameScript>();
            mainScript.CreateTower(selected);
        }
    }
}
