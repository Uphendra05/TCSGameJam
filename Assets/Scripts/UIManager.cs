using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public static UIManager instance;

    public GameObject winPanel, losePanel;
    public AudioSource sound;

    private void Awake()
    {
        if(instance ==  null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void RetryGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        sound.Play();
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        sound.Play();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main");
        sound.Play();
    }

    public void QuitGame()
    {
        Application.Quit();
        sound.Play();
    }

    public void ItchPage()
    {
        Application.OpenURL("https://uphendra.itch.io");
        sound.Play();
    }

    

}
