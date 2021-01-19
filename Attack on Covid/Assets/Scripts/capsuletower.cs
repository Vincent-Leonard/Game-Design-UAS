using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsuletower : MonoBehaviour
{
    public GameObject prefabPeluru;

    private float shootTimerMax;
    private float shootTimer;
    private float angle;
    Vector3 moveDir;
    Vector3 direction;
    Collider2D objectCollider;
    bool yourVar;
    int objects;
    Quaternion rotation;

    // Start is called before the first frame update
    void Start()
    {
        shootTimerMax = 4f;
    }

    // Update is called once per frame
    void Update()
    {
        //bergerak berdasarkan angle
        if(yourVar == true){
            if(objectCollider != null)
            {
                direction = objectCollider.transform.position - transform.position;
                direction = objectCollider.transform.InverseTransformDirection(direction);
                angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            
                rotation = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = rotation;

                moveDir = (objectCollider.transform.position - transform.position).normalized; 

                shootTimer -= Time.deltaTime;
                if(shootTimer <= 0f)
                {
                    shootTimer = shootTimerMax;
                    SpawnPeluru();
                }
            }
        }    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Event ini terpanggil jika trigger tersentuh collider yang lain
        objectCollider = other;

        objects++;
        if(objects != 0){
            yourVar = true;
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
    
    private void SpawnPeluru()
    {
        SoundController.instance.PlaySound(SFXType.CAPSULE);
        var peluruBaru = Instantiate(prefabPeluru);
        peluruBaru.transform.rotation = rotation;
        peluruBaru.GetComponent<GerakanPeluru>().TembakDari(transform.localPosition, moveDir);
    }
}
