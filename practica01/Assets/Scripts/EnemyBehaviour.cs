using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyBall;
    [SerializeField]
    private float speedX=2f;
    [SerializeField]
    private float speedZ=2f;
    private void Start(){
        InvokeRepeating("ShootBall",0,2f);
    }

    void Update()
    {
        transform.Translate(speedX*Time.deltaTime,0,speedZ*Time.deltaTime);
    }

    public void ShootBall(){
        Instantiate(enemyBall,transform.position,transform.rotation);

    }
}
