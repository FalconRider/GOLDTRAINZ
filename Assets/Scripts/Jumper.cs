using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
   private Rigidbody playerRb;
    public bool isOnGround = true;


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround)
        
        playerRb.AddForce(Vector3.up * 10,ForceMode.Impulse);
       // isOnGround = false;
    
        
    }

    private void OnCollisionEnter(Collision collision){
        isOnGround = true;
    }
}
