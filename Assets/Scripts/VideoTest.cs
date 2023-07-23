using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoTest : MonoBehaviour
{
    public InputField field;
    public VideoPlayer videoPlayer;

    public void Start()
    {
        videoPlayer.playOnAwake = false;

    }

    public void PlayVideo()
    {
        {
            // By default, VideoPlayers added to a camera will use the far plane.
            // Let's target the near plane instead.
            //videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;

            // This will cause our Scene to be visible through the video being played.
            videoPlayer.targetCameraAlpha = 0.5F;

            // Set the video to play. URL supports local absolute or relative paths.
            // Here, using absolute.
            videoPlayer.url = field.text;
            
            // Restart from beginning when done.
            videoPlayer.isLooping = true;

            // Start playback. This means the VideoPlayer may have to prepare (reserve
            // resources, pre-load a few frames, etc.). To better control the delays
            // associated with this preparation one can use videoPlayer.Prepare() along with
            // its prepareCompleted event.
            videoPlayer.Play();
        }
    }

    public void StopVideo()
    {
        videoPlayer.Stop();
    }
}
