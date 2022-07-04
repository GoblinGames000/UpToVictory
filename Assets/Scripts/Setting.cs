using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
   public List<Sprite> SoundBtn;
   public List<Sprite> Musictn;
   public List<Sprite> VibBtn;
   public Image Sound;
   public Image Music;
   public Image Vib;

   private void OnEnable()
   {
      Sound.sprite = SoundBtn[PlayerPrefs.GetInt("Sound",1)];
      Music.sprite = Musictn[PlayerPrefs.GetInt("Music",1)];
      Vib.sprite = VibBtn[PlayerPrefs.GetInt("Vib",1)];


   }

   public void ToggleSound()
   {
      Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.buttonClick);
      int status = PlayerPrefs.GetInt("Sound", 1);
      status = Convert.ToInt16(!Convert.ToBoolean(status));
      PlayerPrefs.SetInt("Sound",status);
      Sound.sprite = SoundBtn[status];
      Sound_Manager.instance.ToggleSound();

   } public void ToggleMusic()
   {
      Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.buttonClick);
      int status = PlayerPrefs.GetInt("Music", 1);
      status = Convert.ToInt16(!Convert.ToBoolean(status));
      PlayerPrefs.SetInt("Music",status);
      Music.sprite = Musictn[status];
      Sound_Manager.instance.ToggleMusic();


   } public void Vibration()
   {
      Sound_Manager.instance.PlayOnshootSound(Sound_Manager.instance.buttonClick);
      int status = PlayerPrefs.GetInt("Vib", 1);
      status = Convert.ToInt16(!Convert.ToBoolean(status));
      PlayerPrefs.SetInt("Vib",status);
      Vib.sprite = VibBtn[status];

   }
}
