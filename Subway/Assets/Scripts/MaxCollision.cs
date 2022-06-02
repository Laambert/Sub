using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxCollision : MonoBehaviour
{
    public List<AudioSource> coinAudio;
    public Text scoreText;
    public int score;

    void Update()
    {
        scoreText.text = score.ToString();   
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("coin"))
        {
            coinAudio[Random.Range(0, coinAudio.Count)].Play();
            score += 1;
        }
    }
}
