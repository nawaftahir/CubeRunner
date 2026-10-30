using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TMP_Text scoreText;

    void Update()
    {
        int score = (int)player.position.z + GameManager.instance.coins * 10;
        scoreText.text = score.ToString();
    }
}
