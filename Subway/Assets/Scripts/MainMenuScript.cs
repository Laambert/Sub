using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenuScript : MonoBehaviour
{
    public AudioSource menuAudio;

    public void Start()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
    }

    public void LeaveGame()
    {
        Debug.Log("quit game");
        Application.Quit();
    }

}
