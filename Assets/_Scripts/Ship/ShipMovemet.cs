using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ShipMovemet : MonoBehaviour
{
    [SerializeField] protected Vector3 targetPos;
    [SerializeField] protected float speed = 1.5f;


 private void FixedUpdate() 
 {
    //LAY VI CHUOT TREN TOA DO
   // this.worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
   this.GetTargetPos();
    this.Moving();
    this.LookAtTarget();
 }

    private void Moving()
{
      Vector3 newPos = Vector3.Lerp(transform.parent.position, targetPos, speed);
      transform.parent.position = newPos;
}

    private void GetTargetPos()
    {
      this.targetPos = InputManager.Instance.mouseWorldPod;
      this.targetPos.z = 0;
    }
    protected virtual void LookAtTarget()
    {
        Vector3 diff = this.targetPos - transform.parent.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0f, 0f, rot_z + 90);
        /*
        - Tính vector hướng từ vị trí hiện tại (của đối tượng cha) đến vị trí mục tiêu targetPos.
         - this.targetPos: là một biến Vector3 chứa tọa độ mục tiêu.
         - transform.parent.position: vị trí của đối tượng cha trong không gian.
         - Mathf.Atan2(y, x): trả về góc giữa vector và trục X, đơn vị là radian.


        */
    }
}
   

    
