using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public enum Sate
{
    Main,Play,Pause,Lose,Setting
}

public class CanvasManager : MonoBehaviour
{
    public static CanvasManager Instance;
    public List<GameObject> All;
    public GameObject Main;
    public GameObject Play;
    public GameObject Pause;
    public GameObject Lose;
    public GameObject bg;
    public GameObject Setting;
    public Sate _GamaState;

    private void Awake()
    {
        Instance = this;
    }

    public Sate GamaState
    {
        get { return _GamaState; }
        set
        {
            _GamaState = value;
            switch (value)
            {
                case Sate.Main:
                    TurnOfAll();
                    bg.SetActive(true);
                    Main.Show();
                    break;
                case Sate.Play:
                    TurnOfAll();
                    bg.SetActive(false);
                    Play.Show();

                    break;
                case Sate.Pause:
                    TurnOfAll();
                    Pause.Show();
                    break;
                case Sate.Lose:
                    Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.Lose);
                    TurnOfAll();
                    Lose.Show();
                    break;
                case Sate.Setting:
                    TurnOfAll();
                    Setting.Show();
                    break;
              
                default:
                    throw new ArgumentOutOfRangeException(nameof(value), value, null);
            }
        }

    }

    void TurnOfAll()
    {
        All.ForEach(x => x.Hide());
    }

    private void Start()
    {
        if (Session.Instance.Replay)
        {
            Session.Instance.Replay = false;
            GamaState = Sate.Play;
            return;

        }
            GamaState = Sate.Main;
       
    }

    public void OnClickPlay()
    {
        Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.buttonClick);
        GamaState = Sate.Play;

    }  
    public void OnClickClose()
    {
        Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.buttonClick);
      Application.Quit();

    } public void OnClickToMain()
    {
        Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.buttonClick);
        GamaState = Sate.Main;

    }public void OnClickPause()
    {
        Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.buttonClick);
        GamaState = Sate.Pause;

    }
    public void OnClickResume()
    {
        Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.buttonClick);
        GamaState = Sate.Play;

    }  
    public void OnClickSetting()
    {
        Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.buttonClick);
        GamaState = Sate.Setting;

    } 
    public void OnClickRestart()
    {
        Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.buttonClick);
        Session.Instance.Replay = true;
        Fade.Instance.LoadScene("Game");

    }

  
    // public void OnClickSound()
    // {
    //     Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.buttonClick);
    //     int curr=PlayerPrefs.GetInt("S", 1);
    //     curr = Convert.ToInt16(!Convert.ToBoolean(curr));
    //     if (curr == 1)
    //     {
    //         ButtonImage.color=Color.white;
    //     }
    //     else
    //     {
    //         ButtonImage.color=Color.grey;
    //
    //     }
    //  PlayerPrefs.SetInt("S", curr);
    //   Sound_Manager.instance.ToggleSound();
    //
    // }

   
    
}
