using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    [SerializeField] private GameObject _object;

    void Start()
    {
        Application.targetFrameRate = 60;
    }
    
    private bool isActive;

    public void VisibilitySetter()
    {
        isActive = _object.activeSelf;
        
        _object.SetActive(!isActive);
    }
}
