using UnityEngine;
using UnityEngine.Rendering;

public class BallRoller : MonoBehaviour
{
    public float _speed = 1;

    private void Awake()
    {
        _speed = Random.Range(1, 5);
    }
    void Update()
    {
        transform.position += Vector3.forward * _speed * Time.deltaTime;
    }
}
