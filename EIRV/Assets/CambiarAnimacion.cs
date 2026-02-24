using UnityEngine;
using UnityEngine.InputSystem; // Importante añadir esto

public class CambiarAnimacion : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        // Con el New Input System, accedemos al teclado actual
        var keyboard = Keyboard.current;

        if (keyboard == null) return; // Seguridad por si no hay teclado conectado

        // Comprobamos si cualquiera de las teclas está presionada
        bool estaMoviendose = keyboard.wKey.isPressed ||
                             keyboard.aKey.isPressed ||
                             keyboard.sKey.isPressed ||
                             keyboard.dKey.isPressed;

        animator.SetBool("Andando", estaMoviendose);
    }
}