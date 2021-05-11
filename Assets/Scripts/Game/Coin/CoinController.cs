using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CoinMovement))]
[RequireComponent(typeof(CoinCollision))]
public class CoinController : MonoBehaviour
{
    [SerializeField] private float lifeTime = 5f;
    [SerializeField] private GameObject soundObject;
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
        if (coinMovement.ground && !isDying && lifeTime > 0f)
        {
            isDying = true;
            StartCoroutine(Life());
        }
    }
    public void ItemDestroy()
    {
        if (soundObject)
            Instantiate(soundObject);
        Destroy(gameObject);
    }
    private IEnumerator Life()
    {
        yield return new WaitForSeconds(lifeTime);
        soundObject = null;
        ItemDestroy();
    }
}
