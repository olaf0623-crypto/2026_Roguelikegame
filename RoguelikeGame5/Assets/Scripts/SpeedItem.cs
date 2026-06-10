using UnityEngine;

public class SpeedItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SaveData data = SaveManager.Instance.LoadData();

            data.speedLevel++;

            //SaveManager.Instance.SaveData(data);

            PlayerControll player =
                other.GetComponent<PlayerControll>();

            player.AddSpeed(1f);

            Destroy(gameObject);
        }
    }
}