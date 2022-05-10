using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;

    public float spawnSeparation = 1.5f;

    public int numSpawns;
    public Color gizColor;

    void Awake()
    {
        for (int i = 0; i < numSpawns; i++)
        {
            Instantiate(prefab, transform.position + spawnSeparation*i*Vector3.right, Quaternion.identity, transform);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = gizColor;
        Gizmos.DrawWireSphere(transform.position, 10f);
    }
}
