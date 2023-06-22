using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneSwitch();
        }
    }

    private void SceneSwitch()
    {
        SceneManager.LoadScene("UebersichtsSzeneSmeervs");
        Debug.Log("Scene switcht");
    }
}