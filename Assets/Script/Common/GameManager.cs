using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text intro;
    public float gameTime;
    int count;
    public GameObject start, end, fini;
    public AudioSource adi;

    public GameObject PauseScene;

    bool isPlay = false;

    // Start is called before the first frame update
    void Start()
    {
        adi.Pause();
        start.SetActive(true);
        Time.timeScale = 0;
        gameTime = 0;
        count = 0;
        end.SetActive(false);
        fini.SetActive(false);
        PauseScene.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlay) gameTime += Time.deltaTime;
        if (Mathf.RoundToInt(gameTime) == 0 && count == 0)
        {
            intro.text = "Welcome!";
            count++;
        }
        if (Mathf.RoundToInt(gameTime) == 2 && count == 1)
        {
            intro.text = "Move";
            count++;
        }
        //if (Mathf.RoundToInt(gameTime) == 4 && count == 2)
        //{
        //    intro.text = "Nice";
        //    count++;
        //}
        if (Mathf.RoundToInt(gameTime) == 4 && count == 2)
        {
            intro.text = "Well\nTry to survive";
            count++;
        }
        if (Mathf.RoundToInt(gameTime) == 6 && count == 3)
        {
            intro.text = "Enjoy";
            count++;
        }
        if (Mathf.RoundToInt(gameTime) == 8 && count == 4)
        {
            intro.gameObject.SetActive(false);
            count++;
        }
        if (Mathf.RoundToInt(gameTime) == 65 && count == 5)
        {
            intro.gameObject.SetActive(true);
            intro.text = "";
            count++;
            fini.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPlay = false;
            Time.timeScale = 0;
            adi.Pause();
            PauseScene.SetActive(true);
        }
    }

    public void Play()
    {
        isPlay = true;
        Time.timeScale = 1;
        adi.Play();
        start.SetActive(false);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Resume()
    {
        isPlay = true;
        PauseScene.SetActive(false);
        Time.timeScale = 1;
        adi.UnPause();
    }
}
