using UnityEditor.Build;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class InputTest : MonoBehaviour
{
    NewInputActions newInputActions;

    private void Awake()
    {
        
        newInputActions = new NewInputActions();
    }

    void Start()
    {
        newInputActions.Enable();
        
    }

    private void OnEnable()
    {
        newInputActions.Player.TapHold.performed += OnTap;
        newInputActions.Player.TapHold.performed += OnHold;
    }

    private void OnDisable()
    {
        newInputActions.Disable();
        newInputActions.Player.TapHold.performed -= OnTap;
        newInputActions.Player.TapHold.performed -= OnHold;
    }

    void OnTap(InputAction.CallbackContext ctx)
    {
        if (ctx.interaction is TapInteraction)
        {
            Debug.Log("You are tapping!");
        }
        
    }

    void OnHold(InputAction.CallbackContext ctx)
    {
        if (ctx.interaction is HoldInteraction)
        {
            Debug.Log("You are holding!");
        }
    }


}
