using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject MenuUi;
    public Text text;
    public Count count;


    private void Awake()
    {
        Resume();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }
    }

    public void Pause()
    {
        //меню игры
        MenuUi.SetActive(true);
        Time.timeScale = 0f;
        text.text = $"{count.Score}";
    }


    public void Resume()
    {
        //запуск уровня
        MenuUi.SetActive(false);
        Time.timeScale = 1f;

    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
        count.Score = 0;
        count.Health = 3;
    }
}
