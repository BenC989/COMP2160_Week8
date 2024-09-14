using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    // Define UI text variables
    [SerializeField] private TextMeshProUGUI player1Score;
    [SerializeField] private TextMeshProUGUI player2Score;

    // Define ScoreKeeper
    [SerializeField] private ScoreKeeper scoreKeeper;

    private void Update()
    {
        // Update the UI text
        player1Score.text = "" + scoreKeeper.Player1Score;
        player2Score.text = "" + scoreKeeper.Player2Score;
    }
}
