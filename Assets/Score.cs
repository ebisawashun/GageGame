using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    [SerializeField] Text _scoreText = default;
    int _score = 0;
    private Text score;

    // Start is called before the first frame update
    void Start()
    {
        AddScore(0);
    }

    // Update is called once per frame
    public void AddScore(int score)
    {
        _score += score;
        _scoreText.text = _score.ToString("00");
    }
}
