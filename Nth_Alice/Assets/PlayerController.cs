using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class PlayerController : MonoBehaviour
{

    float distance = 10;
    void OnMouseDrag() {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Screen.height/2, distance); 
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition); 
        transform.position = objPosition;
    }

}
