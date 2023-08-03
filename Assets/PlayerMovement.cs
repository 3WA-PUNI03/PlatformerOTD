using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using static UnityEngine.InputSystem.InputAction;

public class PlayerMovement : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] InputActionReference _moveInput;
    [SerializeField] InputActionReference _jumpInput;
    [SerializeField] GroundChecker _groundChecker;

    [Header("Configuration")]
    [SerializeField] float _movementSpeed;
    [SerializeField] float _jumpPower;

    private void Update()
    {
        // Si le joueur vient d'appuyer sur la touche de saut => on donne une impulsion vers le haut au rigidbody
        // On s'adresse également au GroundChecker pour savoir si on touche le sol ou pas.
        // Si on ne touche pas le sol => on n'autorise pas le saut.
        if (_jumpInput.action.WasPressedThisFrame()  && _groundChecker.IsGrounded == true)
        {
            _rb.AddForce(new Vector2(0, _jumpPower));
        }

        // On récupère la direction droite/gauche du joystick que l'on augmente par la vitesse
        float xAxis = _moveInput.action.ReadValue<Vector2>().x * _movementSpeed;

        // On fourni une nouvelle velocité avec notre direction à nous MAIS 
        // en conservant la vitesse de chute de l'objet pour que la gravité s'accumule progressivement.
        _rb.velocity = new Vector2(xAxis, _rb.velocity.y);
    }
}
