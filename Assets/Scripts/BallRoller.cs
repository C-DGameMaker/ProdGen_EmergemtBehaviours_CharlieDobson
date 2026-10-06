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
        _speed = Random.Range(5, 21);
        rb = GetComponent<Rigidbody>();

        targetPosition = FindObjectOfType<TargetPosMove>().gameObject;
    }
    void Update()
    {
        move = targetPosition.transform.position - rb.position;
        move = move.normalized; // sets the vector's magnitude to 1.0f (the direction remains)
        
        rb.AddForce(move * _speed, ForceMode.Force);
    }



}
