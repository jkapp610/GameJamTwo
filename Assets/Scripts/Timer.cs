using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour{
    float timeremaining =60.0f;
     public Text timetext;
    // Start is called before the first frame update
    void Start()
    {
      settimeText();
        
    }

    // Update is called once per frame
    void Update()
    {
      if(timeremaining >0.00){
          timeremaining -= Time.deltaTime;
          settimeText();
      }
      else{
        SceneManager.LoadScene("Level 1");
      }  
    }
    void settimeText(){
      timetext.text = "Time Remaing: "+timeremaining.ToString("F");

    }
}
