using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LichtDimmen : MonoBehaviour
{
    public Light targetLight; // Das zu beeinflussende Licht
    public float dimmingAmount; // Die Menge, um die das Licht dunkler wird
    public float dimmingInterval; // Das Intervall, in dem das Licht gedimmt wird (in Sekunden)

    private void Start()
    {
        // Starte den Dimming-Prozess in einem Coroutine
        StartCoroutine(DimLightRoutine());
    }

    private System.Collections.IEnumerator DimLightRoutine()
    {
        while (targetLight.intensity > 0f)
        {
            yield return new WaitForSeconds(dimmingInterval);

            // Verringere die Intensität des Lichts
            targetLight.intensity -= dimmingAmount;
        }
    }
}
