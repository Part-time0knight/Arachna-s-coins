using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollision : MonoBehaviour
{
    CoinController coinController;
    private void Awake()
    {
        coinController = GetComponent<CoinController>();
    }
    private void OnControllerColliderHit(ControllerColliderHit player)
    {
        PlayerController playerController = player.gameObject.GetComponent<PlayerController>();
        if (playerController)
        {
            Score.ScoreIncrement();
            coinController.ItemDestroy();
        }
    }
}
