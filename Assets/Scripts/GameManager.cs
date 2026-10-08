using NUnit.Framework;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int s)
    {
        score += s;
    }

    private void ResetScore()
    {
        score = 0;
    }

    public void Die()
    {
        ResetScore();

    }
}
