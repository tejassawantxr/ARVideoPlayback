using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeController : MonoBehaviour
{
   [SerializeField] AudioMixer audioMixer;

   public void setLevel(float sliderValue){
        audioMixer.SetFloat("AudioVol", sliderValue);
   }
}
