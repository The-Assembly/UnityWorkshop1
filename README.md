# UnityWorkshop1
Creating a simple 2D game.
[Assembly team library (1).pdf](https://github.com/The-Assembly/UnityWorkshop1/files/10095770/Assembly.team.library.1.pdf)


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class Score : MonoBehaviour
{
    public static int scoreAmount;
    public Text scoreText;
     public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        //scoreText = GetComponent<Text>;
        scoreAmount =0;
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + scoreAmount;
        
    }

    private void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.CompareTag("Player")){
            scoreText=GameObject.Find("ScoreText").GetComponent<Text>(); 
            Debug.Log(scoreText);
            scoreAmount = scoreAmount + 1;
            scoreText.text =  "Score: " + scoreAmount.ToString();
            Destroy(gameObject);
            
        }
    }
}






// resume code

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    void Update(){
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (GameIsPaused){
                Resume();
            } else {
                Pause();
            }
        }
    }

    public void Resume(){
        Debug.Log("pressed");
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause(){
        Debug.Log("pressed");
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Quit(){
        Debug.Log("quit");
        Application.Quit();
    }
}
