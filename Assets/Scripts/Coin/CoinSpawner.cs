using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject CoinPrefab;
    [SerializeField] private float RangeX = 0f;
    [SerializeField] private float RangeZ = 0f;
    [SerializeField] private float Height = 10f;
    [SerializeField] private float Delay = 0.5f;
    private float time = 0f;
    private void Start()
    {
        
    }
    private void Update()
    {
        time += Time.deltaTime;
        if (time >= Delay)
        {
            Spawn();
            time = 0f;
        }
    }
    private void Spawn()
    {
        float x = Random.Range(-1f * RangeX, RangeX);
        float z = Random.Range(-1f * RangeZ, RangeZ);
        Vector3 point = new Vector3(x, Height, z);
        Instantiate(CoinPrefab, point, Quaternion.identity);
    }
}
