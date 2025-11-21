using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;//singleton
    [SerializeField] public Vector3 mouseWorldPod;

    public static InputManager Instance { get => instance;}

    void Awake()
    {
        if(InputManager.instance !=null) Debug.LogError("Allow 1 0k");
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
