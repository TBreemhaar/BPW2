/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Ghost : MonoBehaviour
{
    void Update() //controls voor player
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up arrow key was pressed.")
            gameObject.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            Debug.Log("Up arrow key was released.")
            gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Right arrow key was pressed.")
            gameObject.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Debug.Log("Right arrow key was released.")
            gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down arrow key was pressed.")
            gameObject.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            Debug.Log("Down arrow key was released.")
            gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("Left arrow key was pressed.")
            gameObject.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            Debug.Log("Left arrow key was released.")                      
            gameObject.SetActive(false);
        }
    }
}

/*void Update()
{
    if (Input.GetKeyDown(KeyCode.Space))
    {
        Debug.Log("Space key was pressed.");
    }

    if (Input.GetKeyUp(KeyCode.Space))
    {
        Debug.Log("Space key was released.");
    }
    UpArrow Up arrow key.
    DownArrow   Down arrow key.
    RightArrow  Right arrow key.
    LeftArrow   Left arrow key.

    if (Input.GetKey("left")) ;
    {
        print("left arrow key is held down");
        gameObject.SetActive(true);
    }
}

public void OpenDoor() //functie die je aanroept om de deur te laten verdwijnen
{
    gameObject.SetActive(false);
}
*/

