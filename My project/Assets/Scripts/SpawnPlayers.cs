using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    private void Start()
    {
        Vector2 randomPosition = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        Vector2 randomPosition2 = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        Vector2 randomPosition3 = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        Vector2 randomPosition4 = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        Vector2 randomPosition5 = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        Vector2 randomPosition6 = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);
        PhotonNetwork.Instantiate(enemyPrefab.name, randomPosition2, Quaternion.identity);
        PhotonNetwork.Instantiate(enemyPrefab.name, randomPosition3, Quaternion.identity);
        PhotonNetwork.Instantiate(enemyPrefab.name, randomPosition4, Quaternion.identity);
        PhotonNetwork.Instantiate(enemyPrefab.name, randomPosition5, Quaternion.identity);
        PhotonNetwork.Instantiate(enemyPrefab.name, randomPosition6, Quaternion.identity);

    }
}
