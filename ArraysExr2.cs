using System.Data.Common;
using TMPro;
using UnityEngine;

public class ArraysExr2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        string[] kalemat = new string[10] {"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
   
        int counter = 0;
        while (counter < 7)
        {    
            int num = Random.Range(0, kalemat.Length);
            string wrd = kalemat[num];
            Debug.Log(wrd);
            counter++;
        }
           
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
