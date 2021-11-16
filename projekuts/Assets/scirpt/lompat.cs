using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lompat : MonoBehaviour{
 
    public float jump;
    bool berpijak = true;


    void Update(){
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)){
            if(berpijak){
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);

            }
        }
    }
}
