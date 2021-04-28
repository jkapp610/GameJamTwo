/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class players : MonoBehaviour{

 public Switchplayer switchPlayer;
   
    // Start is called before the first frame update
   

   void Update(){

    if (Input.GetKeyDown(KeyCode.Space)){
        switchPlayer.changePlayer(this.gameObject);
        GetComponent<GumBall>().enabled = true;


    }
   }
    /*void OnMouseDown(){
        switchPlayer.changePlayer(this.gameObject);
        GetComponent<GumBall>().enabled = true;

    }
}*/
