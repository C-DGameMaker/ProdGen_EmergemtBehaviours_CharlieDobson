using TMPro;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    private int _amountOfBalls;
    private int startX;
    private int startY;
    private int startZ;
    public GameObject _ballPrefab;
    private Transform _spawnPoint;

    private void Awake()
    {
        _amountOfBalls = Random.Range(50, 101);
        _spawnPoint = this.transform;

        for(int i = 0; i < _amountOfBalls; i++)
        {
            startX = Random.Range(-5, 6);
            startY = Random.Range(2, 6);
            startZ = Random.Range(-5, 6);
            _spawnPoint.position = new Vector3(startX, startY, startZ);
            GameObject ball = Instantiate(_ballPrefab, _spawnPoint.position, _spawnPoint.rotation);
        }
    }
}
