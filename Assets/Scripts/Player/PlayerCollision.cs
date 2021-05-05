using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit Coin)
    {
        CoinController coinController = Coin.gameObject.GetComponent<CoinController>();
        if (coinController)
        {
            Score.ScoreIncrement();
            coinController.ItemDestroy();
        }
    }
}
