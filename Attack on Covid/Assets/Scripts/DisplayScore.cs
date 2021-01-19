using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayScore : MonoBehaviour
{   
    Text highscore;
    Text score;
    int sceneID;
    public static int high;
    
    // Start is called before the first frame update
    void Start()
    {
        sceneID = SceneManager.GetActiveScene().buildIndex;
        if(sceneID == 4){
            score = GameObject.Find("Canvas/Score").GetComponent<Text>();
            score.text = "Score: Wave " + EnemySpawn.wave;
        }
        
        highscore = GameObject.Find("Canvas/HighScore").GetComponent<Text>(); 
        if(high < EnemySpawn.wave)
        {
            high = EnemySpawn.wave;
        }

        highscore.text = "HighScore: Wave " + high;
    }

    // Update is called once per frame
    void Update()
    {   
        //
    }
}
