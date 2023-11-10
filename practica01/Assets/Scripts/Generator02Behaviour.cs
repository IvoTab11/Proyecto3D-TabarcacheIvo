using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator02Behaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy02;
    [SerializeField]
    private float initTime;
    [SerializeField]
    private float repeatTime;
    [SerializeField]
    private float speedZ=2f;
    private int cantEnemys=0;
 
    void Start()
    {
            InvokeRepeating("GenerarEnemigos",initTime,repeatTime);
    }

    void Update()
    {
        if(transform.position.z>3.93f || transform.position.z<-5f){
                    speedZ*=-1;
                }
        transform.Translate(0,0,speedZ*Time.deltaTime);
    }

    public void GenerarEnemigos(){
        if(cantEnemys<5){
            Instantiate(enemy02,transform.position,transform.rotation);
            cantEnemys++;
        }
        
    }
}
