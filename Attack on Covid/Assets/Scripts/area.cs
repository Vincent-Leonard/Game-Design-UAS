using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class area : MonoBehaviour
{
    private bool isBeingHeld = false;
    private GameScript mainScript;

    // Update is called once per frame
    void Update()
    {
       if(isBeingHeld == true)
       {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x, mousePos.y, 0);   
       }

    }

    private void OnMouseDown() 
    {
        if(Input.GetMouseButtonDown(0))
        {
            //Vector3 mousePos;
            //mousePos = Input.mousePosition;
            //mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            //isBeingHeld = true;

            var getObject = gameObject.name;
            float areaPosX = GameObject.Find(getObject).transform.position.x;
            float areaPosY = GameObject.Find(getObject).transform.position.y;

            mainScript = GameObject.Find("GameScript").GetComponent<GameScript>();
            mainScript.OnAreaChosen(areaPosX, areaPosY);

            //bunyiin suara
            //SoundController.instance.PlaySound(SFXType.LASER);
        }
    }

    private void OnMouseUp() 
    {
        //isBeingHeld = false;
    }
}
