using UnityEngine;
using UnityEngine.SceneManagement;

public class Candy : MonoBehaviour
{
    public int scoreValue = 10; // Adjust the score value as needed

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            // The candy has collided with the player.
            // Increase the score and destroy the candy object.
            Destroy(gameObject);
        }
    }
}
