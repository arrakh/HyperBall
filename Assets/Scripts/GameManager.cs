using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private int point;

    public Action<int> OnPointChange;

    public int Point 
    { 
        get => point; 
        set
        {
            point = value;
            OnPointChange?.Invoke(point);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
