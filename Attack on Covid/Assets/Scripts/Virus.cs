using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus : MonoBehaviour
{
    public GameObject[] prefabEffect;
    
    private float speed;
    private int health;
    private Vector3 translation;
    private Waypoints Wpoints;
    private int waypointsIndex;
    private syringetower syringetower;
    private EnemySpawn enemySpawn;
    private int var = 10;

    // Start is called before the first frame update
    void Start()
    {
        if(gameObject.tag == "Virus2")
        {
            health = 200;
        }
        else
        {
            health = 100;
        }

        Wpoints = GameObject.FindGameObjectWithTag("Waypoints").GetComponent<Waypoints>();
        enemySpawn = GetComponent<EnemySpawn>();
        speed = 0.01f;

        if(EnemySpawn.wave > 10 && EnemySpawn.wave < 16)
        {
            var += 10;
            speed += 0.01f;
        }
        if(EnemySpawn.wave > 15)
        {
            var += 10;
            speed += 0.02f;
        }
        if(EnemySpawn.wave > 20 && EnemySpawn.wave < 21)
        {
            var += 10;
            speed += 0.03f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Wpoints.waypoints[waypointsIndex].position, speed);

        if (Vector2.Distance(transform.position, Wpoints.waypoints[waypointsIndex].position) < 0.1f)
        {
            waypointsIndex++;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //apa yang terjadi kalo terjadi collision

        //buat ledakan
        var ledakan = Instantiate(prefabEffect[0]);
        ledakan.transform.position = this.transform.position;

        if(collision.collider.tag == "Peluru1"){
            Destroy(collision.collider.gameObject);
            health -= 20;
        }

        if(collision.collider.tag == "Peluru2"){
            Destroy(collision.collider.gameObject);
            health -= 200;
        }

        if(collision.collider.tag == "Peluru3"){
            Destroy(collision.collider.gameObject);
            health -= 15; 
        }

        if(health <= 0){
                Destroy(this.gameObject);
                ChangeText.gold += 10;
                EnemySpawn.virusCountGlobal--;
                //bunyiin suara
                SoundController.instance.PlaySound(SFXType.DIE);
                //buat ledakan
                var ledakan2 = Instantiate(prefabEffect[1]);
                ledakan2.transform.position = this.transform.position;
        }
    }
}