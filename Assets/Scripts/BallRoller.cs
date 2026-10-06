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

    private void Awake()
    {
        _speed = Random.Range(1, 11);
        _speed = _speed / 2;
    }
    void LateUpdate()
    {
       transform.position = Vector3.MoveTowards(transform.position, targetPosition.transform.position, _speed * Time.deltaTime);
        
    }

    

}
