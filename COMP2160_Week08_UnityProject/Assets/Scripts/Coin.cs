using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Singleton
    static private Coin instance;
    static public Coin Instance 
    {
        get 
        {
            if (instance == null)
            {
                Debug.LogError("There is no Coin instance in the scene.");
            }
            return instance;
        }
    }

    void Awake() 
    {
        instance = this;
    }

    // Event handlers
    public delegate void OnPickupEventHandler();
    public event OnPickupEventHandler OnPickupEvent;

    public void PickUp()
    {
        OnPickupEvent?.Invoke();
    }
}
