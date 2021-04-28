using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using.Cinemachine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GumBall : MonoBehaviour{
 
   
    
    Rigidbody2D rigidbody2d;
    public ann annimation;
    float hits = 0;
    float hight =200;
    float mousespeed =100f;
    public Text PowerText;
    float force=700f;
    bool BounceOnOff = true; // ture means you have bounce false means you don't have it
    bool firsttime = true;
    //public gumballmoved = false;
   
    //public CinemachineVirtualCamera Camera;
    // Start is called before the first frame update
    void Start()
    {
         
        rigidbody2d = GetComponent<Rigidbody2D>();
        rigidbody2d.velocity = new Vector2 (0,0);
        setbouncepower();
        
    }

    // Update is called once per frame
    void Update(){
       
    
    }
    void FixedUpdate(){
            Vector3 cursorpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 dir = (cursorpos -transform.position).normalized;
            
            rigidbody2d.AddForce(new Vector2(dir.x*mousespeed,0));
           //gumballmoved = true;


    }

    
    
    
    

    void OnCollisionEnter2D(Collision2D other){

        if (other.gameObject.CompareTag("Ground")){
            rigidbody2d.velocity = new Vector2 (rigidbody2d.velocity.x,0);
            rigidbody2d.AddForce(new Vector2 (0,hight));


        }

        if (other.gameObject.CompareTag("Tri")){
            rigidbody2d.velocity = new Vector2 (rigidbody2d.velocity.x,0);
            if(hight!=0){
            rigidbody2d.AddForce(new Vector2 (0,force));
            force = force+75;
            }
        }
        

        if(other.gameObject.CompareTag("othergumballs")){

            if(BounceOnOff){
            hight =0;
            setbouncepower();
            BounceOnOff = false;
            
            }
            else{
                hight = 500 ;
                 setbouncepower();
                  BounceOnOff = true;
                
            }


        }
         if (other.gameObject.CompareTag("largegumball")){
             //hits = hits +1;
            // if(hits == 10){
                 annimation.Startanimation();
             //}
         }
          if (other.gameObject.CompareTag("trans1")){

                  SceneManager.LoadScene("Level 2");


              }
              if (other.gameObject.CompareTag("trans2")){

                  SceneManager.LoadScene("Level 3");


              }
               if (other.gameObject.CompareTag("trans3")){

                  SceneManager.LoadScene("Level 4");


              }
               if (other.gameObject.CompareTag("trans4")){

                  SceneManager.LoadScene("Win");


              }
        
        
    }
    void OnTriggerEnter2D(Collider2D other) {

          if (other.gameObject.CompareTag("force")){
              if(firsttime){
                   rigidbody2d.AddForce(new Vector2 (6000,10));
                   firsttime= false;

              }

             


          }
    }

    void setbouncepower(){
        PowerText.text ="Bounce Power: "+hight.ToString();
    }

}
