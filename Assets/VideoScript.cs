using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoScript : MonoBehaviour
{
    public VideoPlayer _video;

    public void Click_Button(int id)
    {
        if (id == 0)
        {
            _video.Play();
        }
        else if (id == 1)
        {
            _video.Pause();
        }
        else if (id == 2)
        {
            _video.frame = 0;
            _video.Play();
        }
        else if (id == 3)
        {
            _video.frame = _video.frame + 200;
            _video.Play();
        }
        else if (id == 4)
        {
            _video.frame = _video.frame - 200;
            _video.Play();
        }
    }
}
