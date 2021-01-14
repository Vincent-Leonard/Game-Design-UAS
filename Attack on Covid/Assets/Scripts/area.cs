using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class area : MonoBehaviour
{
    public GameObject prefabVirus;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
       {
          var newVirus = Instantiate(prefabVirus);
          newVirus.transform.position = new Vector2(-8, 4);

          RaycastHit  hit;
          Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
          if (Physics.Raycast(ray, out hit)) {
                 //if (hit.transform.name == "MyObjectName" )Debug.Log( "My object is clicked by mouse");
          }
       }
        //bunyiin suara
        //SoundController.instance.PlaySound(SFXType.LASER);
    }

    void OnMouseDown() 
    {
        //munculin slot
        //var newVirus = Instantiate(prefabVirus);

        //posisi slot
        //newVirus.transform.position = new Vector2(5, 5);


        //prefabVirus.active = true;
        //teleporter.SetActive(true);
    }
}
