using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager instance;
    [SerializeField] public Vector3 mouseWorldPod;
    void Awake()
    {
        InputManager.instance = this;
    }
    void FixedUpdate()
    {
        this.GetMousPos();
    }
    protected virtual void GetMousPos()
    {
        this.mouseWorldPod = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
    }
}
