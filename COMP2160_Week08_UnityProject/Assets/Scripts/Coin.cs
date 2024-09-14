using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int points = 10;

    // Event handlers
    public delegate void OnPickupEventHandler(string player, int points);
    public static event OnPickupEventHandler OnPickupEvent;

    void OnCollisionEnter(Collision collision)
    {
        OnPickupEvent?.Invoke(collision.gameObject.name, points);
        Destroy(gameObject);
    }
}
