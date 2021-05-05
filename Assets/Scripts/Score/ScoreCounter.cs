using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]
public class ScoreCounter : MonoBehaviour
{
    Text text;
    private string startString;
    private void Awake()
    {
        text = GetComponent<Text>();
        startString = text.text;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = startString + Score.score;
    }
}
