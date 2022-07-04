﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Manager : MonoBehaviour
{
    public static Sound_Manager instance;


    public AudioSource BgSource;
    public AudioSource EffectsSource;

    public AudioClip buttonClick;
    public AudioClip Lose;
    public AudioClip Move;

    private void Awake()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            Debug.unityLogger.logEnabled = false;
        }
        BgSource.Play();
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        ToggleMusic();
        ToggleSound();
    }

    public void PlayOnshootSound(AudioClip Clip_)
    {
        EffectsSource.PlayOneShot(Clip_);
    }
  public void StopSound()
    {
        EffectsSource.Stop();
    }

  public void ToggleSound()
  {
      EffectsSource.enabled = Convert.ToBoolean(PlayerPrefs.GetInt("Sound", 1));
  } public void ToggleMusic()
  {
      BgSource.enabled = Convert.ToBoolean(PlayerPrefs.GetInt("Music", 1));
  }

}
