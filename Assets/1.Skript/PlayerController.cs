using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] InputAction movement;

    void Start()
    {

    }

    private void OnEnable()
    {
        movement.Enable();
    }

    private void OnDisable()
    {
        movement.Disable();
    }

    void Update()
    {
        float horizontalThrow = movement.ReadValue<Vector2>().x;
        float verticalThrow = movement.ReadValue<Vector2>().y;

        /*float horizontalThrow = Input.GetAxis("Horizontal");
        Debug.Log(horizontalThrow);
        float verticalThrow = Input.GetAxis("Vertical");
        Debug.Log(verticalThrow);*/
        Debug.Log(horizontalThrow);
        Debug.Log(verticalThrow);

    }
}
