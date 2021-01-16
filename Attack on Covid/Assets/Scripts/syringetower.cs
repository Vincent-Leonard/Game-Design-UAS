using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class syringetower : MonoBehaviour
{
    public GameObject prefabPeluru;

    float speed;
    float angle;
    Vector3 translationVec;
    Vector3 direction;
    static Collider2D test;
    bool yourVar;
    int objects;

    // Start is called before the first frame update
    void Start()
    {
        //dapatkan komponen Sprire Renderer dari gameobject kita
        //mySprite = GetComponent<SpriteRenderer>();
        speed = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        //bergerak berdasarkan angle
        if(yourVar == true){
            direction = test.transform.position - transform.position;
            direction = test.transform.InverseTransformDirection(direction);
            angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            
            Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = rotation;

            translationVec = new Vector3(Mathf.Cos(angle),Mathf.Sin(angle),0); 
        }

        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Event ini terpanggil jika trigger tersentuh collider yang lain
        objects++;
        if(objects != 0){
            yourVar = true;
        }
        test = other;
        
        //buat peluru
        if(objects == 1){
            InvokeRepeating ("SpawnPeluru", 0.0f, 0.5f);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        //Event ini terpanggil jika collider keluar dari trigger
        objects--;
        if(objects == 0){
            yourVar = false;
        }
    }
    
    void SpawnPeluru()
    {
        //if(yourVar == true){
            //var peluruBaru = Instantiate(prefabPeluru);
            //peluruBaru.GetComponent<GerakanPeluru>().TembakDari(transform.localPosition, translationVec);
        //}
    }
}
