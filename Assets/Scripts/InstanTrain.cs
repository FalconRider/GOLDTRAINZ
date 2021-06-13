using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanTrain : MonoBehaviour
{
   
    // Moving it all to github testing
    
    public GameObject Pink;
    void Start()
    {
        InvokeRepeating("Spawn", 2, 6);
    }


    // Update is called once per frame
    void Update()
    {

    }
    public void Spawn()
    {
        GameObject newPink = (GameObject)Instantiate(Pink) as GameObject;
        float x = 0;
        float z = -400;
        float y = 2;
        newPink.transform.position = new Vector3(x, y, z);
        
        Destroy(newPink,15);
    }


}
