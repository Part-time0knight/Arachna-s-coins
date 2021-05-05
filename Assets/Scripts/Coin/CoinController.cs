using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CoinMovement))]
[RequireComponent(typeof(CoinCollision))]
public class CoinController : MonoBehaviour
{
    public const float LIFETIME = 5f;
    CoinMovement coinMovement;
    CoinCollision coinCollision;
    private bool isDying = false;
    private void Awake()
    {
        coinMovement = GetComponent<CoinMovement>();
        coinCollision = GetComponent<CoinCollision>();

    }

    // Update is called once per frame
    void Update()
    {
        coinMovement.Move(Vector3.zero, 0f);
        if (coinMovement.ground && !isDying)
        {
            isDying = true;
            StartCoroutine(Life());
        }
    }
    public void ItemDestroy()
    {
        Destroy(gameObject);
    }
    private IEnumerator Life()
    {
        yield return new WaitForSeconds(LIFETIME);
        ItemDestroy();
    }
}
