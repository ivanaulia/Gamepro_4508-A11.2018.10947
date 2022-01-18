using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnMenuCredit : MonoBehaviour
{
    public void BackScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void KeluarGame(){
        Application.Quit();
        Debug.Log("keluar");
    }
}
