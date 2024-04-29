using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SceneManager : MonoBehaviour
{
    public GameObject panel;
    public InputActionReference inputActionReference;

    private void OnEnable()
    {
        inputActionReference.action.performed += Activar;
        inputActionReference.action.Enable();
    }
    private void OnDisable()
    {
        inputActionReference.action.performed -= Activar;
        inputActionReference.action.Disable();
    }
    public void Activar(InputAction.CallbackContext obj)
    {
        panel.SetActive(!panel.activeSelf);
    }
    
}
