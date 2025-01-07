using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // R�chlos� pohybu hr��a
    private Rigidbody2D rb;     // Referencia na Rigidbody2D hr��a
    private Vector2 movement;   // Uchov�vanie smeru pohybu

    void Start()
    {
        // Priradenie komponentu Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Z�skanie vstupu z kl�vesnice (��pky alebo WASD)
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // Povolenie pohybu iba na jednej osi naraz
        if (moveX != 0)
        {
            moveY = 0; // Zak�e vertik�lny pohyb, ak hr�� ide horizont�lne
        }

        movement.x = moveX;
        movement.y = moveY;
    }

    void FixedUpdate()
    {
        // Aplik�cia pohybu na Rigidbody2D
        rb.velocity = movement * moveSpeed;
    }
}

