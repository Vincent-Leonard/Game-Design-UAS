using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    public static int playerLife;
    public static int global_score;

    public GameObject[] prefabPannel;
    public GameObject[] prefabTower;
    public GameObject[] cost;
    public GameObject[] heart;
    public GameObject warning;

    float areaPositionX, areaPositionY;
    float timer = 0f;
    int wrong;

    private LevelLoader levelloader;

    // Start is called before the first frame update
    void Start()
    {
        prefabPannel[0].SetActive(false);
        prefabPannel[1].SetActive(false);
        prefabPannel[2].SetActive(false);
        cost[0].SetActive(false);
        cost[1].SetActive(false);
        cost[2].SetActive(false);
        warning.SetActive(false);

        playerLife = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerLife == 2)
        {
            heart[2].SetActive(false);
        }
        if(playerLife == 1)
        {
            heart[1].SetActive(false);
        }
        if(playerLife == 0)
        {
            heart[0].SetActive(false);
            levelloader = GameObject.Find("LevelLoader").GetComponent<LevelLoader>();
            levelloader.OnGameOver();
        }

        timer += Time.deltaTime;
        if(wrong == 1){
            warning.SetActive(true);
                if(timer >= 2f){
                    warning.SetActive(false);
                    wrong = 0;
                }
        }
    }

    public void OnAreaChosen(float areaPosX, float areaPosY)
    {
        //jika dapat perintah dari script area maka akan munculin
        prefabPannel[0].SetActive(true);
        prefabPannel[1].SetActive(true);
        prefabPannel[2].SetActive(true);
        cost[0].SetActive(true);
        cost[1].SetActive(true);
        cost[2].SetActive(true);

        areaPositionX = areaPosX;
        areaPositionY = areaPosY;
     
    }

    public void CreateTower(int selected)
    {
        prefabPannel[0].SetActive(false);
        prefabPannel[1].SetActive(false);
        prefabPannel[2].SetActive(false);
        cost[0].SetActive(false);
        cost[1].SetActive(false);
        cost[2].SetActive(false);

        

        if(selected == 0)
        {
            if(ChangeText.gold >= 50)
            {
                var newTower1 = Instantiate(prefabTower[selected]);
                newTower1.transform.position = new Vector2(areaPositionX - 0.2f, areaPositionY);
                var newTower2 = Instantiate(prefabTower[1]);
                newTower2.transform.position = new Vector2(areaPositionX - 0.2f, areaPositionY);
                ChangeText.gold -= 50;
            }else
            {
                timer = 0;
                wrong++;                
            }
        }
        if(selected == 2)
        {   
            if(ChangeText.gold >= 80)
            {
                var newTower1 = Instantiate(prefabTower[selected]);
                newTower1.transform.position = new Vector2(areaPositionX - 0.2f, areaPositionY);
                var newTower2 = Instantiate(prefabTower[3]);
                newTower2.transform.position = new Vector2(areaPositionX - 0.2f, areaPositionY);
                ChangeText.gold -= 80;
            }else
            {
                timer = 0;
                wrong++;             
            }
        }
        if(selected == 4)
        {
            if(ChangeText.gold >= 125)
            {
                var newTower1 = Instantiate(prefabTower[selected]);
                newTower1.transform.position = new Vector2(areaPositionX - 0.2f, areaPositionY + 0.5f);
                var newTower2 = Instantiate(prefabTower[5]);
                newTower2.transform.position = new Vector2(areaPositionX - 0.2f, areaPositionY);
                ChangeText.gold -= 125;
            }else
            {
                timer = 0;
                wrong++;
            }
        }
    }
}
