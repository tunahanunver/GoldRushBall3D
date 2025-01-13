using Runtime.Data.ValueObjects;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    #region Self Variables

    #region Serialized Variables

    [SerializeField] private PlayerMovementController movementController;
        
    #endregion

    #region Private Veriables

    private PlayerData _data;
        
    #endregion
        
    #endregion

    private void Awake()
    {
        GetPlayerData();
        SendDataToControllers();
    }

    private void GetPlayerData()
    {
        _data = Resources.Load<CD_Player>("Data/CD_Player").Data;
    }

    private void OnEnable()
    {
        SubscribeEvents();
    }

    private void OnDisable()
    {
        UnSubscribeEvents();
    }

    private void SubscribeEvents()
    {
        InputSignals.Instance.onInputTaken += movementController.OnInputTaken;

    }

    private void UnSubscribeEvents()
    {
        InputSignals.Instance.onInputTaken += movementController.OnInputTaken;

    }

    private void SendDataToControllers()
    {
        movementController.SetMovementData(_data.MovementData);
    }
}