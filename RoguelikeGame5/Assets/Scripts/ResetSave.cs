using UnityEngine;
using UnityEngine.InputSystem;

public class ResetSave : MonoBehaviour
{
    private void Update()
    {
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            SaveData data = new SaveData();

            SaveManager.Instance.SaveData(data);

            Debug.Log("세이브 초기화 완료!");
        }
    }
}