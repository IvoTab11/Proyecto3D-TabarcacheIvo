using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField]
    private float speedZ=2f;
 
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,speedZ*Time.deltaTime);
    }
}
