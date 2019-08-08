using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //zodat we verschillende scenes kunnen managen

public class GameOverMenu : MonoBehaviour
{
    //in deze functie laden we de game opnieuw
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); //om de index van ons huidige level te krijgen
    }

    //in deze functie laten we de game eindigen
    public void QuitGame ()
    {
        Debug.Log("Quit"); //hiermee controleren we of de knop werkt (en de game daadwerkelijk beëindigt wordt
        Application.Quit(); //dit zou daadwerkelijk de game moeten beëindigen
    }
}
