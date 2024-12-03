using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnterCheck : MonoBehaviour
{
    [SerializeField] private GameObject deathScreen;
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log($"Коллайдеры столкнулись! {gameObject.name} столкнулся с {other.gameObject.name}");
        Time.timeScale = 0.0f;
        deathScreen.SetActive(true);
    }
}
