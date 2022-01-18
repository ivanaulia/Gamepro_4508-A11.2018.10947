using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void MulaiGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void KeluarGame(){
        Application.Quit();
        Debug.Log("keluar");
    }
    public void CreditGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void HelpGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
}
