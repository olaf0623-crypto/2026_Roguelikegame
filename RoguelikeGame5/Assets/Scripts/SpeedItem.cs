using UnityEngine;

public class SpeedItem : MonoBehaviour
{
    public SpeedItemData itemData;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SaveData data = SaveManager.Instance.LoadData();

            data.speedLevel++;
            data.speedItemCount++;

            SaveManager.Instance.SaveData(data);

            PlayerControll player =
                other.GetComponent<PlayerControll>();

            player.AddSpeed(itemData.speedIncrease);

            Destroy(gameObject);
        }
    }
}