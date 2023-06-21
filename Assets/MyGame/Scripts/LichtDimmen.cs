using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LichtDimmen : MonoBehaviour
{
    public Light targetLight;
    public float dimmingAmount;
    public float dimmingInterval;

    private void Start()
    {
        StartCoroutine(DimLightRoutine());
    }

    private System.Collections.IEnumerator DimLightRoutine()
    {
        while (targetLight.intensity > 0f)
        {
            yield return new WaitForSeconds(dimmingInterval);

            targetLight.intensity -= dimmingAmount;
        }
    }
}