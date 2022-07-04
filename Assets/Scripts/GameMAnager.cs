using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameMAnager : MonoBehaviour
{
    public static GameMAnager Instance;
    public AnimationCurve _Anim;
    public float TimeVal;
    public Transform Parent;
    public int _LifeCount;
    public int LifeCount
    {
        get
        {
            return _LifeCount;
        }
        set
        {
            _LifeCount = value;
            foreach (Transform VARIABLE in Parent)
            {
                VARIABLE.gameObject.SetActive(false);
            }
            for (int i = 0; i < _LifeCount; i++)
            {
                Parent.GetChild(i).gameObject.SetActive(true);
            }

            if (_LifeCount <= 0)
            {
                CanvasManager.Instance.GamaState = Sate.Lose;
            }
        }
    }

    public float GetSpeed()
    {
        return _Anim.Evaluate(TimeVal);
    }

    private void Update()
    {
        if (CanvasManager.Instance.GamaState == Sate.Play)
        {
            TimeVal += Time.deltaTime;
        }
    }

    private void OnEnable()
    {
        LifeCount = 3;
    }

    private void Awake()
    {
        Instance = this;
    }
}
