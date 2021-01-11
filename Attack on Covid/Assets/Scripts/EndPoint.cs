using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //disaat ada trigger maka destroy
        Destroy(other.gameObject);
    }
}
