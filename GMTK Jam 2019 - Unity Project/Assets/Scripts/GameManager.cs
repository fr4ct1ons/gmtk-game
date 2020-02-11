using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gm = null;

    public delegate void VoidDelegate();

    public static event VoidDelegate OnGameStart;
    
    private void Awake()
    {
        if (!gm)
            gm = this;
        else
            Destroy(gameObject);
    }

    public void StartGame()
    {
        OnGameStart?.Invoke();
    }
}