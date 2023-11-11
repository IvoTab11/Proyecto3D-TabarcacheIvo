using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator02Behaviour : MonoBehaviour
{
    //Representa el prefab del Enemigo02.
    [SerializeField]
    private GameObject enemy02;
    //Representa el tiempo en el que se iniciará el método "GenerarEnemigos".
    [SerializeField]
    private float initTime;
    //Representa el tiempo en el que se repetirá el método "GenerarEnemigos".
    [SerializeField]
    private float repeatTime;
    [SerializeField]
    //Representa la velocidad en la que se desplazará el generador en el eje Z.
    private float speedZ=2f;
    //Contador que representa la cantidad de enemigos. Corrobora la cantidad de enemigos que se generen.
    private int cantEnemys=0;
 
    void Start()
    {
            InvokeRepeating("GenerarEnemigos",initTime,repeatTime);
    }

    void Update()
    {
        //Se corrobora que el generador haya llegado al límite del plano.
        if(transform.position.z>3.93f || transform.position.z<-5f){
            //Cambia la dirección en la que avanzará el generador.
                    speedZ*=-1;
        }
        transform.Translate(0,0,speedZ*Time.deltaTime);
    }

    public void GenerarEnemigos(){
        //Se corrobora que la cantidad de enemigos sea menor a 5. Si se cumple la condición, se generan más.
        if(cantEnemys<5){
            Instantiate(enemy02,transform.position,transform.rotation);
            cantEnemys++;
        }
        
    }
}
