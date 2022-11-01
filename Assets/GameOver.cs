using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;
public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text scoreText;
    public Temp MouseMovement;
    public GameObject ply;
    public GameObject bkg;
    public GameObject CF;
    public GameObject hM;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Setup(int score){
        MouseMovement.gameEnd = true;
        ply.GetComponent<MouseMovement>().enabled = false;
        bkg.GetComponent<moveBkg>().enabled = false;
        CF.GetComponent<CameraFollow>().enabled = false;
        hM.GetComponent<HomingMissile>().enabled = false;
        gameObject.SetActive(true);
        scoreText.text = "Score : " + score.ToString();
    }

    public void RestartButton() {
        SceneManager.LoadScene("Game");
        // Invoke(3);
    }

    public void MainMenuButton(){
        SceneManager.LoadScene("MainMenu");
    }
}
