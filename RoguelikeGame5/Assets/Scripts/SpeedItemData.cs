using UnityEngine;

[CreateAssetMenu(
    fileName = "SpeedItemData",
    menuName = "Game/Speed Item Data"
)]
public class SpeedItemData : ScriptableObject
{
    public string itemName;

    public float speedIncrease;
}