using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonController : MonoBehaviour
{
    [SerializeField] private float personSpeed = 10.0f;

    private Vector2 personDirection = Vector2.right;

    private Vector2 startTouchPosition;

    private Vector2 endTouchPosition;


    private void Start()
    {
        Time.timeScale = 1.0f;
    }

    private void Update()
    {
        if(WindowOnTriggerEnter.playerInTrigger)
        {
            if (Input.GetKey(KeyCode.UpArrow))
                personDirection = Vector2.up;
            else if (Input.GetKey(KeyCode.DownArrow))
                personDirection = Vector2.down;
            else if (Input.GetKey(KeyCode.LeftArrow))
                personDirection = Vector2.left;
            else if (Input.GetKey(KeyCode.RightArrow))
                personDirection = Vector2.right;

            HandleTouchInput();
        }
        

        transform.Translate(personDirection * personSpeed * Time.deltaTime);
    }

    private void HandleTouchInput()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startTouchPosition = touch.position;
                    break;
                case TouchPhase.Ended:
                    endTouchPosition = touch.position;
                    DetectSwipe(startTouchPosition, endTouchPosition);
                    break;
            }
        }
    }

    private void DetectSwipe(Vector2 start, Vector2 end)
    {
        Vector2 swipeDirection = end - start;

        if (swipeDirection.magnitude >= 50) // Минимальная длина свайпа
        {
            if (Mathf.Abs(swipeDirection.x) > Mathf.Abs(swipeDirection.y))
            {
                // Свайп горизонтальный
                if (swipeDirection.x > 0 && personDirection != Vector2.left)
                    personDirection = Vector2.right;
                else if (swipeDirection.x < 0 && personDirection != Vector2.right)
                    personDirection = Vector2.left;
            }
            else
            {
                // Свайп вертикальный
                if (swipeDirection.y > 0 && personDirection != Vector2.down)
                    personDirection = Vector2.up;
                else if (swipeDirection.y < 0 && personDirection != Vector2.up)
                    personDirection = Vector2.down;
            }
        }
    }
}
