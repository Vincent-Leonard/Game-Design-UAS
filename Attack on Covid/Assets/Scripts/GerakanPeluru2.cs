﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakanPeluru2 : MonoBehaviour
{
    float speed = 0.1f;
    Vector3 moveDir;
    float BATAS_KANAN = 10f;
    float BATAS_KIRI = -10f;
    float BATAS_ATAS = 5f;
    float BATAS_BAWAH = -5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gerakan peluru sesuai arahnya
        transform.localPosition += moveDir * speed;

        if((transform.localPosition.x > BATAS_KANAN) || (transform.localPosition.x < BATAS_KIRI) || (transform.localPosition.y > BATAS_ATAS) || (transform.localPosition.y < BATAS_BAWAH))
        {
            Destroy(gameObject);
            //gameObject itu semacam this
        }
    }

    public void TembakDari(Vector3 posAwal, Vector3 direction)
    {
        //taruh peluru di posisi awal
        transform.localPosition = new Vector3(posAwal.x - 0.7f, posAwal.y + 0.5f, posAwal.z);
        
        //set arah peluru
        moveDir = new Vector3(0,0,0); 
    }
}
