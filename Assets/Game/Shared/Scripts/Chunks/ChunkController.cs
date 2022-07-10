using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkController : MonoBehaviour
{
    public Transform spawnPoint;
    public ChunkManager chunkManager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            chunkManager.PlayerHasPassedChunk();
        }
    }
}
