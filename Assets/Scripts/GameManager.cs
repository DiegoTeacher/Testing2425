using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public enum InterfaceVariable { TIME, COINS };

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private float currentGameTime = 0;
    private int coins = 0;

    void Awake()
    {
        // SINGLETON
        if(!instance) // instance == null
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        currentGameTime += Time.deltaTime;
    }

    public float GetTime()
    {
        return currentGameTime;
    }

    public void AddCoins(int value)
    {
        coins += value;
    }

    public int GetCoins()
    {
        return coins;
    }
}
