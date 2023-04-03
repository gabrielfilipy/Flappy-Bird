using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
    
    private float cTimer = 0f;
    public GameObject pipe;
    public float height;
    public float maxTime = 1;

    void Start() {
        GameObject newPipe = Instantiate(pipe);    
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);   
    }

    void Update() {
 
        if(cTimer > maxTime) {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0); 
            Destroy(newPipe, 15);
            cTimer = 0;
        }

        cTimer += Time.deltaTime;

    }
}
