using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    private int _amountOfBalls;
    public GameObject _ballPrefab;
    private Transform _spawnPoint;

    private void Start()
    {
        _spawnPoint = this.transform;
        _amountOfBalls = Random.Range(100, 200);

        for(int i = 0; i < _amountOfBalls; i++)
        {
            GameObject ball = Instantiate(_ballPrefab, _spawnPoint.position, _spawnPoint.rotation);
        }
    }
}
