using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusMovement : MonoBehaviour
{
    float speed;
    private Vector3 translation;
    private Waypoints Wpoints;
    private int waypointsIndex;
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
}