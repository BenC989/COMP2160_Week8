using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private Coin coin;

    private int currentScore = 0;

    // Singleton
    static private ScoreKeeper instance;
    static public ScoreKeeper Instance 
    {
        get 
        {
            if (instance == null) 
            {
                Debug.LogError("There is no ScoreKeeper in the scene.");
            }            
            return instance;
        }
    }

    void Awake() 
    {
        // If there is already a ScoreKeeper in the scene, destroy this one
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    void Start()
    {
        // Find the Coin script
        coin = gameObject.GetComponent<Coin>();

        // Subscribe to OnPickupEvent
        Coin.OnPickupEvent += OnPickup;
    }

    void OnPickup()
    {
        currentScore += 10;
        Debug.Log("Current Score: " + currentScore);
    }

    // Getter for CurrentScore
    public int CurrentScore
    {
        get 
        {
            return currentScore;
        }
    }
}
