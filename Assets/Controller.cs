using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controller : MonoBehaviour {
    
    public int score;
    public Text scoreText;

    public void RestartGame() {
        SceneManager.LoadScene(0);
    }   

    public void Start() {
        Time.timeScale = 1;
    }
    
}
