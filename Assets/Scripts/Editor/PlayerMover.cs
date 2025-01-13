using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private float speed = 10;

    void Awake()
    {
        GetReferences();
    }

    private void GetReferences()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Debug.Log("çalışıyor");
    }
}
