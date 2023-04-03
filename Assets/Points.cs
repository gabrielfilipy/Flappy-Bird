using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour {

    public Controller controller;

    public void Start() {
        controller = FindObjectOfType<Controller>();
    }

    public void OnTriggerEnter2D(Collider2D c) {
        controller.score++;
        controller.scoreText.text = controller.score.ToString();
    }
}
