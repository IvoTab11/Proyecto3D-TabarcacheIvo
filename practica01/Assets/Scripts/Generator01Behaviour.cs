using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator01Behaviour : MonoBehaviour
{
    //Representa al prefab "Enemigo01".
    [SerializeField]
    private GameObject enemy01;
    //Representa el tiempo en el que se iniciará el método "GenerarEnemigos".
    [SerializeField]
    private float initTime;
    //Representa el tiempo en el que se repetirá el método "GenerarEnemigos".
    [SerializeField]
    private float repeatTime;

    void Start()
    {
        InvokeRepeating("GenerarEnemigos",initTime,repeatTime);
    }
    public void GenerarEnemigos(){
        Instantiate(enemy01,transform.position,transform.rotation);
    }
}
