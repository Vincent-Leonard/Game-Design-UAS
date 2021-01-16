using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    int money;
    int stopWatch;
    static float areaPositionX, areaPositionY;

    public GameObject[] prefabPannel;
    public GameObject[] prefabTower;

    private slot1 slot1;
    private slot2 slot2;
    private slot3 slot3;

    // Start is called before the first frame update
    void Start()
    {
        prefabPannel[0].SetActive(false);
        prefabPannel[1].SetActive(false);
        prefabPannel[2].SetActive(false);
        money = 10000;
        stopWatch = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnAreaChosen(float areaPosX, float areaPosY)
    {
        //jika dapat perintah dari script area maka akan munculin
        prefabPannel[0].SetActive(true);
        prefabPannel[1].SetActive(true);
        prefabPannel[2].SetActive(true);

        areaPositionX = areaPosX;
        areaPositionY = areaPosY;
     
    }

    public void CreateTower(int selected)
    {
        prefabPannel[0].SetActive(false);
        prefabPannel[1].SetActive(false);
        prefabPannel[2].SetActive(false);
        if(selected == 0)
        {
            var newTower1 = Instantiate(prefabTower[selected]);
            newTower1.transform.position = new Vector2(areaPositionX, areaPositionY);
            var newTower2 = Instantiate(prefabTower[1]);
            newTower2.transform.position = new Vector2(areaPositionX, areaPositionY);
        }
        else
        {
            var newTower = Instantiate(prefabTower[selected]);
            newTower.transform.position = new Vector2(areaPositionX, areaPositionY);
        }
    }
}
