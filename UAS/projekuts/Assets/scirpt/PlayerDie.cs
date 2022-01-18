using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerDie : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D target){
        if (target.gameObject.tag == "deadly" || target.gameObject.tag == "monster") { //tabrakan dgn objek memiliki tag
            Die(); //panggil fungsi die()
        }
    }

    void Die(){
        GameObject go = GameObject.Find("SetingGame"); //cari gameobject bernama pengaturgame pada hierarchy
        ScriptPengaturan pg = (ScriptPengaturan)go.GetComponent(typeof(ScriptPengaturan));//ambil scriptpengaturgame
        pg.Respawning(); //memakai metode respawning yang sudah public
        Destroy (gameObject); //destroy diri sendiri
    }
}
