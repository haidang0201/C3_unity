using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovemet : MonoBehaviour
{
    [SerializeField] protected Vector3 worldPos;
    [SerializeField] protected float speed = 1.5f;


 private void FixedUpdate() 
 {
    //LAY VI CHUOT TREN TOA DO
   // this.worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
   this.worldPos = InputManager.Instance.mouseWorldPod;
    this.worldPos.z = 0;
    Vector3 newPos = Vector3.Lerp(transform.parent.position, worldPos, speed);
    transform.parent.position = newPos;
 }
    
   


}
   

    
