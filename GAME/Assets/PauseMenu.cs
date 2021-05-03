using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour
{
    public Button resumeButton;
    public static bool GameIsPaused = false;
    public AudioMixer audioMixer;

    // Update is called once per frame
    void Update()
    {
        //Pause();
        
    }

    void Resume()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        gameObject.SetActive(false); 
    }

    void Pause()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

   

    void OnEnable()
    {
        Pause();
    }

    public void Bind()
    {
        
        resumeButton?.onClick.AddListener(Resume);

    }

    public void Unbind()
    {
        
        resumeButton?.onClick.RemoveAllListeners();
    }

    public void Start()
    {
        Bind();
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume",volume);
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
