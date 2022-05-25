using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneGEçiş : MonoBehaviour
{
    
    public void AnaMenü()
    {
        SceneManager.LoadScene("NasılOynanır");
    }
    public void ilksahne()
    {
        SceneManager.LoadScene("oyunsahnesi");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void TekrarDene()
    {
        SceneManager.LoadScene("oyunsahnesi");
    }
    public void OyunSonuSahnesi()
    {
        SceneManager.LoadScene("oyunsonusahnesi");
    }

}
