using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    Text waveTxt;
    Text virusCountTxt;
    Text goldTxt;
    private int waveText;
    public static int gold;

    // Start is called before the first frame update
    void Start()
    {
        waveTxt = GameObject.Find("Canvas/WaveText").GetComponent<Text>();
        virusCountTxt = GameObject.Find("Canvas/VirusCount").GetComponent<Text>();
        goldTxt = GameObject.Find("Canvas/GoldText").GetComponent<Text>();

        gold = 100;
        EnemySpawn.wave = 1;
        EnemySpawn.virusCountGlobal = 5;
    }

    // Update is called once per frame
    void Update()
    {
        waveTxt.text = ": " + EnemySpawn.wave;

        virusCountTxt.text = "Virus Left : " + EnemySpawn.virusCountGlobal;

        goldTxt.text = "Gold : " + gold;

    }

}
