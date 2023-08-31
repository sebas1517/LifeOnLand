using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Interact : MonoBehaviour
{
    Vector2 position;

    GameObject treePlant1;
    GameObject treePlant2;
    GameObject treePlant3;
    GameObject deforestationStatic;
    GameObject deforestationUp;

    RaycastHit hit;

    Ray ray;



    // Start is called before the first frame update

    void Start()
    {
        treePlant1 = GameObject.Find("treePlant1");
        treePlant2 = GameObject.Find("treePlant2");
        treePlant3 = GameObject.Find("treePlant3");
        deforestationUp = GameObject.Find("deforestationUp");
        deforestationStatic = GameObject.Find("deforestationStatic");
        if (treePlant1 != null)
        {
            treePlant1.SetActive(false);
        }
        if (treePlant2 != null)
        {
            treePlant2.SetActive(false);
        }
        if (treePlant3 != null)
        {
            treePlant3.SetActive(false);
        }
        if (deforestationUp != null) {
            deforestationUp.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        position = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
        ray = CAVE2.GetCameraController().GetMainCamera().ScreenPointToRay(position);
        Physics.Raycast(ray, out hit, Mathf.Infinity);
        Debug.Log(hit.collider.gameObject.name);

        if(CAVE2.GetButtonDown(CAVE2.Button.Button5)) {
        switch (hit.collider.gameObject.name){
            case "rep1":
                if (treePlant1 != null) {
                    treePlant1.SetActive(true);
                }
                 break;
            }
        switch (hit.collider.gameObject.name){
            case "rep2":
                if (treePlant2 != null) {
                    treePlant2.SetActive(true);
                }
                 break;
            }
        switch (hit.collider.gameObject.name){
            case "rep3":
                if (treePlant3 != null) {
                    treePlant3.SetActive(true);
                }
                 break;
            }
        }
        if (treePlant1.activeSelf && treePlant2.activeSelf && treePlant3.activeSelf) {
            deforestationUp.SetActive(true);
            deforestationStatic.SetActive(false);
        }
    }
}
