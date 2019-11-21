using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public static int score = 0;

    private void Start()
    {
        score=0;
    }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
}
