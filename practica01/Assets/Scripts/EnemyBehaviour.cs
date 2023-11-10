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
    [SerializeField]
    private int enemyType;
    [SerializeField]
    private float speedXEnemy02=2f;
    private float randomTime=0;
    private void Start(){
        switch(enemyType){
            case 1:
            {
                InvokeRepeating("ShootBall",0,2f);
                break;
            }
            case 2: {
                Invoke("ShootBall",randomTime);
                break;
            }
        }
   
    }

    void Update()
    {
        moveEnemy();
    }

    public void ShootBall(){
        Instantiate(enemyBall,transform.position,transform.rotation);
        if(enemyType==2){
            randomTime = Random.Range(1,3);
            Invoke("ShootBall",randomTime);
        }
    }

    public void moveEnemy(){
        switch(enemyType){
            case 1:
            {
                transform.Translate(speedX*Time.deltaTime,0,speedZ*Time.deltaTime);
                break;
            }
             case 2:
            {
                if(transform.position.x<-4.44f || transform.position.x>4.44f){
                    speedXEnemy02*=-1;
                }
                transform.Translate(speedXEnemy02*Time.deltaTime*-1,0,0);
                break;
            }
        }
    }
}
