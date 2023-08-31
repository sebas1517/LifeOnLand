using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpAndStop : MonoBehaviour
{
    public float speed = 10f;

    private float timer = 0f;
    private bool shouldMove = true;

    // Update is called once per frame
    void Update()
    {
        if (shouldMove) {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            timer += Time.deltaTime;
            if(timer >= 2f) {
                shouldMove = false;
            }
        }
    }
}
