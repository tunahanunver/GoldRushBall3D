using Runtime.Data.ValueObjects;
using Runtime.Keys;
using Unity.Mathematics;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    #region Self Variables

    #region Serialized Variables

    [SerializeField] private PlayerManager manager;
        
    #endregion

    #region Private Variables

    private float2 _inputvalues;
    private Rigidbody _rigidbody;
    private PlayerMovementData _data;
        
    #endregion
        
    #endregion

    private void Awake()
    {
        GetReferences();
    }

    private void GetReferences()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    internal void SetMovementData(PlayerMovementData movementData)
    {
        _data = movementData;
    }

    internal void OnInputTaken(InputParams inputparams)
    {
        _inputvalues = inputparams.InputValues;
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        _rigidbody.velocity += new Vector3(_inputvalues.x, 0, _inputvalues.y) * (_data.Speed * Time.fixedDeltaTime);
    }
}