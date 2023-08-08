using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoSeeker : MonoBehaviour
{
    public Slider slider;
    public VideoPlayer videoPlayer;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        float value = (float) videoPlayer.frame / (float) videoPlayer.frameCount;
        // float value = (float)videoPlayer.time;
        slider.value = value;
        Debug.Log("Slider-value===>"+ value);
        Debug.Log("videoPlayer.frame===>"+ videoPlayer.frame);
        Debug.Log("videoPlayer.frameCount===>"+ videoPlayer.frameCount);
    }

    // public void VideoOnSliderChange(float SliderValue){
    //     videoPlayer.frame = (long) SliderValue * (long)videoPlayer.frameCount;
    // }

}
