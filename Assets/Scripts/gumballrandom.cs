using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gumballrandom : MonoBehaviour
{

    Rigidbody2D rigidbody2d;
    bool dir = false;
    // Start is called before the first frame update
    void Start()
    {
         rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate(){
        if(dir){
         rigidbody2d.AddForce(new Vector2(100,0));
         dir= false;
        }
        else{
            rigidbody2d.AddForce(new Vector2(-100,0));
            dir = true;

            
        }

    }
}
