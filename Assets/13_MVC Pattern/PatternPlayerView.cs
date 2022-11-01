using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PatternPlayerView : MonoBehaviour
{
    private Text playerPositionText;
    private const string DistanceConcat = "Distanec to destination";

    private void Awake()
    {
        playerPositionText = GetComponent<Text>();
    }

    public void update(PatternPlayer player)
    {
        playerPositionText.text = DistanceConcat + player.getDistanceToDestination().ToString();
    }
}
