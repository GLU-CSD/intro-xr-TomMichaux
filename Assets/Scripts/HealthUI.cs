using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUI : MonoBehaviour
{

    public string prefabTag = "Enemy"; // Zorg dat je prefab deze tag heeft
    private HeadTracking healthScript;

    private void Update()
    {
        GameObject spawnedPrefab = GameObject.FindWithTag(prefabTag);
        if (spawnedPrefab != null)
        {
            healthScript = spawnedPrefab.GetComponent<HeadTracking>();
        }
    }

    public void DamageButton()
    {
        if(healthScript != null)
        {
            healthScript.TakeDamage(10);
        }
    }

    public void HealButton()
    {
        if(healthScript != null)
        {
            healthScript.RestoreHealth(10);
        }
    }
}


