using UnityEngine;

public class NPCFollower : MonoBehaviour
{
    public Transform player; // Referencia na hlavnÈho hr·Ëa
    public float speed = 4f; // R˝chlosù pohybu NPC
    public float followDistance = 20.5f; // Minim·lny odstup od hr·Ëa (zv‰Ëöen˝ o 3 cm) // Minim·lny odstup od hr·Ëa

    void Update()
    {
        if (player != null)
        {
            // VypoËÌtaù vzdialenosù od hr·Ëa
            float distance = Vector2.Distance(transform.position, player.position);

            // Skontrolovaù, Ëi je vzdialenosù v‰Ëöia ako minim·lny odstup
            if (distance > followDistance)
            {
                // VypoËÌtaù smer k hr·Ëovi
                Vector2 direction = (player.position - transform.position).normalized;

                // Pohybovaù NPC smerom k hr·Ëovi
                transform.Translate(direction * speed * Time.deltaTime);
            }
        }
    }
}
