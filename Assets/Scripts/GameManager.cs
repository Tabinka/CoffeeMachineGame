using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameOver);
        if (gameOver)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        SceneManager.LoadScene(0); // menu
    }
}
