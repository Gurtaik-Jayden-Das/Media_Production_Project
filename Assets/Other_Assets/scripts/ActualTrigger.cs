using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger: " + other.gameObject.name);

    }
}
