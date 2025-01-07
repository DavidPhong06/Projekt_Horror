using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // R˝chlosù pohybu hr·Ëa
    private Rigidbody2D rb;     // Referencia na Rigidbody2D hr·Ëa
    private Vector2 movement;   // Uchov·vanie smeru pohybu

    void Start()
    {
        // Priradenie komponentu Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // ZÌskanie vstupu z kl·vesnice (öÌpky alebo WASD)
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // Povolenie pohybu iba na jednej osi naraz
        if (moveX != 0)
        {
            moveY = 0; // Zak·ûe vertik·lny pohyb, ak hr·Ë ide horizont·lne
        }

        movement.x = moveX;
        movement.y = moveY;
    }

    void FixedUpdate()
    {
        // Aplik·cia pohybu na Rigidbody2D
        rb.velocity = movement * moveSpeed;
    }
}

