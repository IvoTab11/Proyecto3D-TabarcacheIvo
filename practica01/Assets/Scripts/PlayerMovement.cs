using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed=2f;
    //Representa las balas del jugador.
    [SerializeField]
    private GameObject ballPlayer;

    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal")*speed*Time.deltaTime,0,0);
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(ballPlayer,transform.position,transform.rotation);
        }
    }
}
