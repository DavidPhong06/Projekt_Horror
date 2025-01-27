using UnityEngine;

public class NPCFollower : MonoBehaviour
{
    public Transform player; // Referencia na hlavn�ho hr��a
    public float speed = 4f; // R�chlos� pohybu NPC
    public float followDistance = 20.5f; // Minim�lny odstup od hr��a (zv��en� o 3 cm) // Minim�lny odstup od hr��a

    void Update()
    {
        if (player != null)
        {
            // Vypo��ta� vzdialenos� od hr��a
            float distance = Vector2.Distance(transform.position, player.position);

            // Skontrolova�, �i je vzdialenos� v��ia ako minim�lny odstup
            if (distance > followDistance)
            {
                // Vypo��ta� smer k hr��ovi
                Vector2 direction = (player.position - transform.position).normalized;

                // Pohybova� NPC smerom k hr��ovi
                transform.Translate(direction * speed * Time.deltaTime);
            }
        }
    }
}
