using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Light mushroomLight;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mushroomLight.enabled = true;
            Debug.Log("Light aan");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mushroomLight.enabled = false;
            Debug.Log("Light uit");
        }
    }
}
