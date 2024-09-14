using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Event handlers
    public delegate void OnPickupEventHandler();
    public static event OnPickupEventHandler OnPickupEvent;

    void OnCollisionEnter(Collision collision)
    {
        OnPickupEvent?.Invoke();
        Destroy(gameObject);
    }
}
