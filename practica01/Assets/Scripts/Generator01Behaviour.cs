using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator01Behaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy01;
    [SerializeField]
    private float initTime;
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
