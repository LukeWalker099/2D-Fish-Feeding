using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Collectable")]
    public Text goldText;
    public static int goldValue;

    [Header("Score")]
    public Text scoreText;
    public static int scoreValue;

    private void Update()
    {
        scoreText.text = "" + scoreValue;

        goldText.text = "" + goldValue;
    }


}
