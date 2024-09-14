// Include packages
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player2 : MonoBehaviour
{
    // Define input action variables
    private PlayerActions actions;
    private InputAction movementAction;

    // Define movement and position-related variables
    [Range(1,10)] [SerializeField] private float speed = 5f;
    private float horizontalMovement;
    private float verticalMovement;

    private void Awake()
    {
        actions = new PlayerActions();
        movementAction = actions.movement.player2move;
    }

    private void OnEnable()
    {
        movementAction.Enable();
    }

    private void OnDisable()
    {
        movementAction.Disable();
    }

    private void Update()
    {
        // Read player movement input
        horizontalMovement = movementAction.ReadValue<Vector2>().x;
        verticalMovement = movementAction.ReadValue<Vector2>().y;

        // Move the player
        transform.Translate(Vector3.forward * speed * verticalMovement * Time.deltaTime, Space.World);
        transform.Translate(Vector3.right * speed * horizontalMovement * Time.deltaTime, Space.World);
    }
}