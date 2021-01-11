using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject virusPrefab;
    public float interval = 2;
    public int wave = 1;
    public int virusCount = 20;
    float timer = 0f;

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
    }

    void createVirus()
    {
        var newPrefab = Instantiate(virusPrefab);

        var xSpawn = 2.25f;
        var ySpawn = 5.74f;
        newPrefab.transform.position = new Vector2(xSpawn, ySpawn);
    }
}
