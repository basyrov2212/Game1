using UnityEngine;

public class TriggerEnterCheck : MonoBehaviour
{
    [SerializeField] private GameObject deathScreen;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Проверяем, что это игрок
        {
            //Debug.Log($"Коллайдеры столкнулись! {gameObject.name} столкнулся с {other.gameObject.name}");
            Time.timeScale = 0.0f;
            deathScreen.SetActive(true);
        }
    }
}
