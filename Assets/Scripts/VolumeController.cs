using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VolumeController : MonoBehaviour
{
  public VideoPlayer videoPlayer;
  public GameObject Unmute;
  public GameObject Mute;
  bool isMuted=false;

  void Start(){
    Unmute.SetActive(!isMuted);
    Mute.SetActive(isMuted);
  }

  public void AdjustVideoVolume(float Volume){
    videoPlayer.SetDirectAudioVolume(0, Volume);
  }

  public void MuteAndUnmuteAudio(){
    isMuted = !isMuted;
    Unmute.SetActive(!isMuted);
    Mute.SetActive(isMuted);
    videoPlayer.SetDirectAudioMute(0, isMuted);
    Debug.Log("isMuted"+ isMuted);
  }
}
