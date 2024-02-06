using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    // After this time, the object will be destroyed

    [Header("Default Desrtuction Time")]
    public float timeToDesrtuction;

    void Start()
    {
        Invoke("DestroyObject", timeToDesrtuction);
    }

    // Update is called once per frame
    void DestroyObject()
    {
        Destroy(gameObject);
    }
}

