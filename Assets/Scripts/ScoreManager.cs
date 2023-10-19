using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static int score = 0;

    public static void AddPoints(int points)
    {
        score += points;
        Debug.Log("Score: " + score);
    }
}
