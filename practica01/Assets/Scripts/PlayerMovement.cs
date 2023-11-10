using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed=2f;
    [SerializeField]
    private GameObject ballPlayer;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal")*speed*Time.deltaTime,0,0);
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(ballPlayer,transform.position,transform.rotation);
        }
    }
}
