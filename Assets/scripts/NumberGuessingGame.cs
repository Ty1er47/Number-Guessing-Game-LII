using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGuessingGame : MonoBehaviour
{
    // Start is called before the first frame update
    
    // Start is called before the first frame update
    
     void Start()
    {
      StartGame();
    }

    private int guess = 5;
    private int minValue = 1;
    private int maxValue = 10;
    void Start()
    {
    StartGame();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.UpArrow))
       {
         minValue = guess;
         guess = (maxValue + minValue) / 2;
         Debug.Log("Is it higher or lower than: " + guess);
       } 
       if(Input.GetKeyDown(KeyCode.DownArrow))
       {
           maxValue = guess;
           guess = (maxValue + minValue) /2;
           Debug.Log("Is it higher or lower than: " + guess);
        }
          if(Input.GetKeyDown(KeyCode.Return)) 
        {
          Debug.Log("I guessed your number,I'm a genius!!");
          Debug.Log("");
          StartGame();
        }
    }

     void StartGame () 
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
