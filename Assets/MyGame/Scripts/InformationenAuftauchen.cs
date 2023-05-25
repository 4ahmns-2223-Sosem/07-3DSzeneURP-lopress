using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationenAuftauchen : MonoBehaviour
{
    public GameObject erklaerText; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            erklaerText.SetActive(true); 
        }
        else
        {
            erklaerText.SetActive(false);
        }
    }
}

