using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private Weponia weaponia;
    [SerializeField] private PlayerInput Input;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    void Awake()
    {
        Input.actions["Shoot"].performed += ctx => HandleShooting(ctx.ReadValueAsButton());
    }

    void HandleShooting(bool ishooting)
    {
        if (ishooting)
        {
            weaponia.StartShoot();
        }
        else
        {
            weaponia.StopShoot();
        }

    }
    
}
