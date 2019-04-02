using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField]

    Transform UIPanel;
    bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        UIPanel.gameObject.SetActive(false);
        isPaused = false;


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && !isPaused)
        {
            Pause();
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && isPaused)
        {
            UnPause();
        }

    }
    public void Pause()
    {
        isPaused = true;
        UIPanel.gameObject.SetActive(true);
    }
    public void UnPause()
    {
        isPaused = false;
        UIPanel.gameObject.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Restart()
    {
        Application.LoadLevel(0);
    }

}
