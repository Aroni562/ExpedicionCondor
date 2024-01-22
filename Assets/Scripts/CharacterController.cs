using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    
    [SerializeField] private float moveSpeed;
    private Animator _animator;
    private Vector2 _directionCharacter = Vector2.one;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        // Combina las entradas de teclado para obtener la dirección de movimiento
        Vector2 movementDirection = new Vector2(horizontalInput, verticalInput).normalized;
        
        if (movementDirection != Vector2.zero)
        {
            
            _directionCharacter.x = (horizontalInput >= 0.25f) ? 1f : (horizontalInput <= -0.25f) ? -1f : horizontalInput;
            _directionCharacter.y = (verticalInput >= 0.25f) ? 1f : (verticalInput <= -0.25f) ? -1f : verticalInput;


            // Setea los parámetros para la animación
            _animator.SetFloat("DirectionX", _directionCharacter.x * 100f);
            _animator.SetFloat("DirectionY", _directionCharacter.y * 100f);
            _animator.SetBool("IsMoving", true);
            
            // Debug.Log(horizontalInput);
            // Debug.Log(verticalInput);

            // Aplica la dirección de movimiento y la velocidad al objeto
            transform.Translate(movementDirection * moveSpeed * Time.deltaTime);
        }
        else
        {
            // Si no se está moviendo, establece la animación de idle
            _animator.SetBool("IsMoving", false);
        }
        
    }
}
