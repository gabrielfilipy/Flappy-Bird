using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float speed = 1f;
    private Rigidbody2D rg;
    public GameObject gameOver;

    void Start() {
        rg = GetComponent<Rigidbody2D>();
    } 

    void Update() {
        if(Input.GetMouseButtonDown(0)) {
           rg.velocity = Vector2.up * speed;
        }
    }

    void OnCollisionEnter2D(Collision2D c) {
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }

}
