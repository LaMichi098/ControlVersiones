using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giro : MonoBehaviour
{
    [SerializeField] private float degreesPerSecond = 5f;
    private Transform _transform;

    void Awake()
    {
        Debug.Log("Awake");
        _transform = transform;
    }

    void Start()
    {
        Debug.Log("Start");
    }
    void Update()
    {
        Debug.Log("Update");
        _transform.Rotate(0f, 0f, degreesPerSecond * Time.deltaTime);
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}
