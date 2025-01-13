using Runtime.Keys;
using Unity.Mathematics;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    #region Self Variables
    
    #region Private Variables

    private float2 _inputvalues;
        
    #endregion

    #endregion

    private void Update()
    {
        _inputvalues = GetInputValues();
        if(!Input.anyKey) return;
        SendInput();
    }

    private void SendInput()
    {
        InputSignals.Instance.onInputTaken?.Invoke(new InputParams()
        {
            InputValues = _inputvalues
        });
    }

    private float2 GetInputValues()
    {
        return new float2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }
}
