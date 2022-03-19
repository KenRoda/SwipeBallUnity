using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class MyGameController : MonoBehaviour
{
    private GameObject myGameText;

    // Start is called before the first frame update
    void Start()
    {
        this.PauseGame();
        this.myGameText = GameObject.Find("MyGameText");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.ResumeGame();
            this.myGameText.GetComponent<Text>().text = "";
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void GameClear()
    {
        this.myGameText.GetComponent<Text>().text = "Game Clear \n Time:" + Time.time;
        this.PauseGame();
    }
}