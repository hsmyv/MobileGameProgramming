using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemennyyu : MonoBehaviour
{
    public static bool GameisPaused = false;
    public GameObject MenuUI;
    public GameObject Menubuttonu;

    public GameObject UmumiUI;
    public AudioSource ses;
    // Start is called before the first frame update

    // Update is called once per frame
    public void Start()
    {
        MenuUI.SetActive(false);
    }

    public void Pausebutton1()
    {
        MenuUI.SetActive(true);
        Time.timeScale = 0f;
        Debug.Log("isledi");
        Menubuttonu.SetActive(false);
        UmumiUI.SetActive(false);
        ses.Play();
    }
    
     
 public void ResumeButton()
    {
        MenuUI.SetActive(false);
        Time.timeScale = 1f;
        Menubuttonu.SetActive(true);
        Debug.Log("islediresume");
        UmumiUI.SetActive(true);
        ses.Stop();
    }


}