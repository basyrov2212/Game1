using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowOnTriggerEnter : MonoBehaviour
{
    public static bool playerInTrigger;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Проверяем, что это игрок
        {
            //Debug.Log("Игрок вошел в триггер");
            playerInTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("Игрок вышел из триггера");
            playerInTrigger = false;
        }
    }
}
