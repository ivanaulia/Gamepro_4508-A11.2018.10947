using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakter : MonoBehaviour
{
   public int aksi;
    public int coinTag;
    public int score;
    public float speed;
    public float speedRotasi;

    Vector3 kekanan;
    Vector3 kekiri;
    Vector3 keatas;
    Vector3 kebawah;
    Vector3 maju;
    Vector3 mundur;

    static Quaternion toQuaternion(Vector3 euler)
    {
        Quaternion q;
        float pitch = euler.y;
        float roll = euler.x; 
        float yaw = euler.z;
        float t0 = Mathf.Cos(yaw * 0.5f);
        float t1 = Mathf.Sin(yaw * 0.5f);
        float t2 = Mathf.Cos(roll * 0.5f);
        float t3 = Mathf.Sin(roll * 0.5f);
        float t4 = Mathf.Cos(pitch * 0.5f);
        float t5 = Mathf.Sin(pitch * 0.5f);
        //Debug.Log(t0 + " " + t1 + " " + t2 + " " + t3 + " " + t4 + " " + t5 + " ");

        q.x = t0 * t3 * t4 - t1 * t2 * t5;
        q.y = t0 * t2 * t5 + t1 * t3 * t4;
        q.z = t1 * t2 * t4 - t0 * t3 * t5;
        q.w = t0 * t2 * t4 + t1 * t3 * t5;
        return q;
    }

    // Start is called before the first frame update
    void Start()
    {
        kekanan = new Vector3(1,0,0);
        kekiri = new Vector3(-1,0,0);
        keatas = new Vector3(0,1,0);
        kebawah = new Vector3(0,-1,0);
        maju = new Vector3(0,0,1);
        mundur = new Vector3(0,0,-1);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("right")){
            transform.position = transform.position + (kekanan * speed * Time.deltaTime);
        }
        if(Input.GetKey("left")){
            transform.position = transform.position + (kekiri * speed * Time.deltaTime);
        }
        if(Input.GetKey("space")){
            transform.position = transform.position + (keatas * speed * Time.deltaTime);
        }
        if(Input.GetKey("down")){
            transform.position = transform.position + (kebawah * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D)){
            transform.position = transform.position + (maju * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A)){
            transform.position = transform.position + (mundur * speed * Time.deltaTime);
        }

        /*
        switch(aksi){
            case 0:
                //translasi ke kanan
                transform.position = transform.position + (kekanan * speed * Time.deltaTime);
                break;
            case 1:
                //translasi ke kiri
                transform.position = transform.position + (kekiri * speed * Time.deltaTime);
                break;
            case 2:
                //translasi ke atas
                transform.position = transform.position + (keatas * speed * Time.deltaTime);
                break;
            case 3:
                //translasi ke bawah
                transform.position = transform.position + (kebawah * speed * Time.deltaTime);
                break;
            case 4:
                //rotasi ke kanan
                transform.rotation = transform.rotation * toQuaternion(maju * speedRotasi * Time.deltaTime);
                break;
            case 5:
                //rotasi ke kiri
                transform.rotation = transform.rotation * toQuaternion(mundur * speedRotasi * Time.deltaTime);
                break;
        }
        */
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "monster")
        {
            Debug.Log ("Game Over");
            Time.timeScale = 0;
        }
        if(coll.gameObject.tag == "coinTag")
        {
            coinTag++;
            Debug.Log("Anda mendapatkan coin "+coinTag);
        }
    }

    void OnCollisionStay2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "monster")
        {
            Debug.Log ("Sedang Nabrak");
        }

    }

    void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "monster")
        {
            Debug.Log ("Sudah Nabrak");
        }

    }
}