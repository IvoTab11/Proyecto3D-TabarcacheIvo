using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    //Representa la velocidad en el eje Z.
    [SerializeField]
    private float speedZ=2f;
 
    void Update()
    {
        transform.Translate(0,0,speedZ*Time.deltaTime);
        if(transform.position.z<-5f || transform.position.z>4.5f){
            Destroy(this.gameObject);
        }
    }
}
