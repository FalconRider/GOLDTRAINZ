using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedTrainScript : MonoBehaviour
{

    private Vector3 startPos;
    public float repeatPos = 50;
    private float speed = 70;
   
    void Start()
    {
         startPos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
         if(transform.position.z < startPos.z - repeatPos ){
            transform.position = startPos;}


        
        
    }
}
