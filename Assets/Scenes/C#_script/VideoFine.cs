using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoFine : MonoBehaviour
{
    VideoPlayer video;

    void Awake()
    {
        video = GetComponent<VideoPlayer>();
        video.loopPointReached += CheckOver;
        //video.url = System.IO.Path.Combine(Application.streamingAssetsPath, "video-incipit.mp4");
        //video.url = "http://localhost:8888/StreamingAssets/video-incipit.mp4";
        video.Play();

    }


    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadScene("level_tutorial");//the scene that you want to load after the video has ended.
    }
}
