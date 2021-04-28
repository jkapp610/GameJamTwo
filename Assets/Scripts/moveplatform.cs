﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplatform : MonoBehaviour{
         public float speed;
    public bool vertical;
    public float changeTime = 3.0f;

    Rigidbody2D rigidbody2D;
    float timer;
    int direction = 1;
  
    float timeremaining =2.0f;
    bool moving =false;

    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        timer = changeTime;
        timeremaining = changeTime;
    }

    void Update()
    {
        
        timer -= Time.deltaTime;

        if (timer < 0){
            direction = -direction;
            timer = changeTime;
            moving= false;
            timeremaining= changeTime;
         
        }
    
    
    }
    
    
    void FixedUpdate(){
        
       

        

        
        
     
      
        Vector2 position = rigidbody2D.position;
         
        
        if (vertical)
        {
            position.y = position.y + Time.deltaTime * speed * direction;
        }
        else
        {
            position.x = position.x + Time.deltaTime * speed * direction;
        }
        
        rigidbody2D.MovePosition(position);
        
        }
    
    
    
    
    
}


