using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationenAuftauchen : MonoBehaviour
{
    public GameObject erklaerText;
    public AudioClip soundClip;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = soundClip;
        audioSource.playOnAwake = false;

        erklaerText.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            erklaerText.SetActive(true);
            audioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.Stop();
            erklaerText.SetActive(false);
        }
    }

}