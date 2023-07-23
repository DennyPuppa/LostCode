using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoFinale1 : MonoBehaviour
{
    VideoPlayer video;

    void Awake()
    {
        video = GetComponent<VideoPlayer>();
        //video.url = System.IO.Path.Combine(Application.streamingAssetsPath, "finale_uno.mp4");
        video.loopPointReached += CheckOver;
        video.Play();

    }


    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadScene("menu_principale");//the scene that you want to load after the video has ended.
    }
}
