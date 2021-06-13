using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenTrainMover : MonoBehaviour
{
private float speed = 37;
        void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
       // private float place = Vector3.z;
       // if (place >= 260) {
      //      Vector3.z == -460;
        
        
    }
}
