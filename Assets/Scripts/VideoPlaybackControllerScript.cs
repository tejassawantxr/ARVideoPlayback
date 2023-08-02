using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlaybackControllerScript : MonoBehaviour
{
  public VideoPlayer videoPlayer;

  public void PlayVideo(){
    videoPlayer.Play();
  }

  public void PauseVideo(){
    videoPlayer.Pause();
  }

  public void StopVideo(){
    videoPlayer.Stop();
  }

  public void AdjustVideoVolume(float Volume){
    videoPlayer.SetDirectAudioVolume(0, Volume);
  }
}
