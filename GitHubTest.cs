using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class GitHubTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
     void Start() 
     { 
        int counter = 0; 
        while (counter < 20) 
        {
           int randomNumb = Random.Range(1, 20); 
           Debug.Log(randomNumb); 
           counter++;
          if (randomNumb == 5)
         { 
                 continue;
          } 
          else if (randomNumb == 15)
           { 
            break;  
            }
          }

       }

}

    
