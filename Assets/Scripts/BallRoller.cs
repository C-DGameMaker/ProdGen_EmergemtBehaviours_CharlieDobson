using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class BallRoller : MonoBehaviour
{
    public float _speed = 1;
    public Vector3 move;

    private void Awake()
    {
        _speed = Random.Range(1, 5);

        move = Random.insideUnitSphere;

        if(move == Vector3.zero)
        {
            move = Vector3.left;
        }
        if (move == Vector3.up)
        {
            move = Vector3.right;
        }

        move = move.normalized;

    }
    void Update()
    { 
        transform.position += move * _speed * Time.deltaTime;
    }
}
