using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
   

    public GameObject youWonPanel; // You Won Paneli

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            youWonPanel.SetActive(true); 
            Time.timeScale = 0; 
        }
    }


}
