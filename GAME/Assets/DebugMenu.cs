using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugMenu : MonoBehaviour
{
    public float fov;
    public Button resumeButton;
    public static bool GameIsPaused = false;
    public Button plus;
    public Button minus;
    public GameObject Player;
    public Button ffplus;
    public Button ffminus;
    public Button sfplus;
    public Button sfminus;
    public Button marlboro;
    public Button nivea;
    public Button starbucks;
    public Button persol;
    public Material marlboroMaterial;
    public Material niveaMaterial;
    public Material starbucksMaterial;
    public Material persolMaterial;
    //public GameObject Players;





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
        plus?.onClick.AddListener(CameraZoom);
        minus?.onClick.AddListener(CameraUnzoom);
        ffplus?.onClick.AddListener(ForwardForceraise);
        ffminus?.onClick.AddListener(ForwardForceDecrease);
        sfplus?.onClick.AddListener(SidewaysForceraise);
        sfminus?.onClick.AddListener(SidewaysForceDecrease);
        marlboro?.onClick.AddListener(Marlboro);
        nivea?.onClick.AddListener(Nivea);
        starbucks.onClick.AddListener(Starbucks);
        persol.onClick.AddListener(Persol);

    }

    public void Unbind()
    {

        resumeButton?.onClick.RemoveAllListeners();
        plus.onClick.AddListener(CameraZoom);
        minus.onClick.AddListener(CameraUnzoom);
        ffplus.onClick.AddListener(ForwardForceraise);
        ffminus.onClick.AddListener(ForwardForceDecrease);
        sfplus.onClick.AddListener(SidewaysForceraise);
        sfminus.onClick.AddListener(SidewaysForceDecrease);
        marlboro.onClick.AddListener(Marlboro);
        nivea.onClick.AddListener(Nivea);
        starbucks.onClick.AddListener(Starbucks);
        persol.onClick.AddListener(Persol);
    }

    public void Start()
    {
        Bind();
    }

    public void CameraZoom()
    {
        var fov = Camera.main.fieldOfView;
        fov += 5;
        if (fov < 100)
        {
            Camera.main.fieldOfView = fov;
        }
    }

    public void CameraUnzoom()
    {
        var fov = Camera.main.fieldOfView;
        fov += 5;
        if (fov > 10)
        {
            Camera.main.fieldOfView = fov;
        }
    }

    public void ForwardForceraise()
    {
        Player.GetComponent<PlayerMovment>().forwardForce += 100;
    }

    public void ForwardForceDecrease()
    {
        Player.GetComponent<PlayerMovment>().forwardForce -= 100;

    }

    public void SidewaysForceraise()
    {
        Player.GetComponent<PlayerMovment>().sidewaysForce += 4;
    }

    public void SidewaysForceDecrease()
    {
        Player.GetComponent<PlayerMovment>().sidewaysForce -= 4;

    }
    
    public void Marlboro()
    {
        Player.GetComponent<Renderer>().material = marlboroMaterial;


    }

    public void Nivea()
    {
        Player.GetComponent<Renderer>().material = niveaMaterial;


    }

    public void Starbucks()
    {
        Player.GetComponent<Renderer>().material = starbucksMaterial;


    }

    public void Persol()
    {
        Player.GetComponent<Renderer>().material = persolMaterial;


    }




}
