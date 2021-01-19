using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] virusPrefab;
    public float interval = 2;
    public static int wave = 1;
    public int virusCount = 5;
    public static int virusCountGlobal = 5;
    public int virusTotal = 5;
    float timer = 0f;
    public float waveInterval = 5;

    void Update()
    {
        if (virusCount > 0)
        {
            if(timer <= interval)
            {
                timer += Time.deltaTime;
            }
            else
            {
                createVirus();
                virusCount--;
                timer = 0;
            }
        }

        if(virusCountGlobal < 0)
        {
            virusCountGlobal = 0;
        }

        if(virusCountGlobal == 0)
        {
            if(timer <= waveInterval)
            {
                timer += Time.deltaTime;
            }
            else
            {
                GameObject[] coba1 = GameObject.FindGameObjectsWithTag("Effects");
                for(var i=0;i<coba1.Length;i++)
                {
                    Destroy(coba1[i]);
                }
                virusTotal = virusTotal + (virusTotal* 2/10);
                interval -= interval * 1 / 10;
                virusCount = virusTotal;
                virusCountGlobal = virusTotal;
                timer = 0;
            }
        }
    }

    void createVirus()
    {
        if(wave > 5)
        {
            var newPrefab = Instantiate(virusPrefab[Random.Range(0, virusPrefab.Length)]);

            var xSpawn = 2.25f;
            var ySpawn = 5.74f;
            newPrefab.transform.position = new Vector2(xSpawn, ySpawn);
        }
        else
        {
            var newPrefab = Instantiate(virusPrefab[0]);

            var xSpawn = 2.25f;
            var ySpawn = 5.74f;
            newPrefab.transform.position = new Vector2(xSpawn, ySpawn);
        }
    }
}
