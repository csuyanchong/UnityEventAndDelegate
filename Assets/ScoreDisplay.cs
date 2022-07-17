using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreDisplay : MonoBehaviour
{
    public Text txtScore;
    [HideInInspector]
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.score = 0;
        txtScore.text = this.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        Enermy.enermyKilled += UpdateScore;
    }
    private void OnDisable()
    {
        Enermy.enermyKilled -= UpdateScore;
    }
    public void UpdateScore()
    {
        score += 10;
        txtScore.text = score.ToString();
    }
}
