using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusMovement : MonoBehaviour
{
    float speed;
    int health = 5;
    private Vector3 translation;
    private Waypoints Wpoints;
    private int waypointsIndex;
    private syringetower syringetower;

    // Start is called before the first frame update
    void Start()
    {
        Wpoints = GameObject.FindGameObjectWithTag("Waypoints").GetComponent<Waypoints>();
        speed = 0.01f;
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
        if(collision.collider.tag == "Peluru"){
            //meledak !!!
            //buat ledakan
            //var ledakan = Instantiate(prefabExplosion);
            //set position
            //ledakan.transform.position = this.transform.position;

            Destroy(collision.collider.gameObject);
            health--;
            if(health == 0){
                Destroy(this.gameObject);
            }

            //gameku.AddScore(10);
            //gameku.AdaMusuhMati();

            //bunyiin suara
            //SoundController.instance.PlaySound(SFXType.SPLAT);
        }
    }
}