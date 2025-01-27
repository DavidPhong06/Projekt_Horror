using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // R˝chlosù pohybu hr·Ëa

    private Vector2 movement;

    void Update()
    {
        // ZÌskanie vstupu od hr·Ëa (öÌpky alebo WASD)
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        // Zak·zanie diagon·lneho pohybu
        if (horizontal != 0 && vertical != 0)
        {
            vertical = 0; // Ak hr·Ë drûÌ dve kl·vesy, pohyb diagon·lne nie je povolen˝
        }

        // Nastavenie pohybu
        movement = new Vector2(horizontal, vertical).normalized;
    }

    void FixedUpdate()
    {
        // Aplik·cia pohybu
        transform.Translate(movement * speed * Time.fixedDeltaTime);
    }
}
