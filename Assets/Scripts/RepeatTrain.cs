using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatTrain : MonoBehaviour
{
    private Vector3 startPos;
    public float repeatPos = 50;
    
    void Start()
    {
        startPos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < startPos.z - repeatPos ){
            transform.position = startPos;}
            }
        
        
    
}
