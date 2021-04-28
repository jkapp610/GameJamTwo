using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ann : MonoBehaviour
{
     Animator animator;
    public GameObject gumball;
    SpriteRenderer spriterender;
    GameObject gumball2;
     
    int framecount = 118;
    int ballstate = 0;
    int timer = 0;
    int time2 =0;

     //Start is called before the first frame update
    void Start(){
         animator = GetComponent<Animator>();
         this.spriterender= GetComponent<SpriteRenderer>();
         animator.enabled = false;
         
        



        
    }

    // Update is called once per frame
    void Update(){


        time2 ++;
    if(ballstate == 1){
        Debug.Log("timer: " + timer.ToString() );
       
        timer++;
    }
    if( timer >= framecount ){
        ballstate = 2;
         time2 ++;
        animator.enabled = false;
        this.spriterender.enabled =false;

        //this.gameObject.SetActive(false);
        if(time2 >120){

        float rand = Random.Range(-3.0f, 3.0f);
       Instantiate(gumball, new Vector3(114.02f+rand ,19.28f, 0), Quaternion.identity);
       
        time2 =0;
        }
    }
}
        
    
    public  void Startanimation(){
        animator.enabled = true;
        ballstate= 1;
          Debug.Log("ballstate: " + ballstate.ToString() );
        
       
        
    }
}
