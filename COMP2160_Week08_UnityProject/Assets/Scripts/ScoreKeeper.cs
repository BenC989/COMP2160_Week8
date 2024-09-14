using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private Coin coin;

    private int player1Score = 0;
    private int player2Score = 0;

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

    void OnPickup(string player, int points)
    {
        if (player == "Player1")
        {
            player1Score += points;
            Debug.Log("Player 1 Score: " + player1Score);
        }
        if (player == "Player2")
        {
            player2Score += points;
            Debug.Log("Player 2 Score: " + player2Score);
        }
    }

    // Getter for Player1Score
    public int Player1Score
    {
        get 
        {
            return player1Score;
        }
    }

    // Getter for Player2Score
    public int Player2Score
    {
        get 
        {
            return player2Score;
        }
    }
}
