using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnMenuHelp : MonoBehaviour
{
    public void BackScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    public void KeluarGame(){
        Application.Quit();
        Debug.Log("keluar");
    }
}
