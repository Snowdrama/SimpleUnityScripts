using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OpenPauseMenu : MonoBehaviour, Controls.IInterfaceActions
{
    Controls controls;
    public StackBasedMenu menu;

    void Start()
    {
        controls = new Controls();
        controls.Enable();

        controls.Interface.SetCallbacks(this);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPause(InputAction.CallbackContext context)
    {
        if(context.started)
        {
            menu.OpenMenu("PauseMenu");
        }
    }
}
