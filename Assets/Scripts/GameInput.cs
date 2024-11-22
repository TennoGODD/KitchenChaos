using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    PlayerInputActions playerInputActions;
    private void Awake() {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
    }
    public Vector2 GetMovement()
    {
        Vector2 inputMove = playerInputActions.Player.Move.ReadValue<Vector2>(); 

        inputMove = inputMove.normalized;
        
        return inputMove;
    }
}
