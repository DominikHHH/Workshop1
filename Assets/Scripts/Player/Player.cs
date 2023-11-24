using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    //      The player's main input/collision detection code

    // Inputs
    private Vector2 inputMove;
    private bool inputRun;

    // Components
    PlayerController controller;

    private void Awake()
    {
        controller = GetComponent<PlayerController>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Debug.Log("Input is pressed");
    }

    public void OnRun()
    {
        Debug.Log("Input is pressed");
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
