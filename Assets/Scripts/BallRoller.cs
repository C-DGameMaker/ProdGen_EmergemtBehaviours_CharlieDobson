using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class BallRoller : MonoBehaviour
{
    public float _speed = 1;
    public GameObject targetPosition;

    private Rigidbody rb;
    private Vector3 move;

    private void Awake()
    {
        _speed = Random.Range(1, 11);
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        move = targetPosition.transform.position - rb.position;
        rb.AddForce(move * _speed, ForceMode.Force);
    }

    

}
