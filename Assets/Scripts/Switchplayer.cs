/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switchplayer : MonoBehaviour
{
  
    //public CinemachineVirtualCamera vcam;
    public GameObject[] Gumballs;
    [SerializeField]
    GameObject currentGumBall;

   //public GameObject gumball1;
    //public GameObject gumball2;
    // Start is called before the first frame update
    void Start(){

        for (int i = 1; i < Gumballs.Length; i++){
            Gumballs[i].GetComponent<GumBall>().enabled = false;

            
        }

        currentGumBall = Gumballs[0];

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changePlayer(GameObject G){
        //Get the  Gumball script of the current gumball
        currentGumBall.GetComponent<GumBall>().enabled = false;
        currentGumBall =G;
    }
}
*/