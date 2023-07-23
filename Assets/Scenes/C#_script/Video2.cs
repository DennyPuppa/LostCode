using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;


public class Video2 : MonoBehaviour
{
    VideoPlayer video;

    void Awake()
    {
        video = GetComponent<VideoPlayer>();
        video.loopPointReached += CheckOver;
        //video.url = System.IO.Path.Combine(Application.streamingAssetsPath, "video-livellodue-tre.mp4");
        //video.url = "http://localhost:8888/StreamingAssets/video-livellodue-tre.mp4";
        video.Play();

    }


    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadScene("NewLevel3");//the scene that you want to load after the video has ended.
    }
}
