using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoFinale2 : MonoBehaviour
{
    VideoPlayer video;

    void Awake()
    {
        video = GetComponent<VideoPlayer>();
        //video.url = "http://localhost:8888/StreamingAssets/finale_due.mp4";
        //video.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Finale2 (Pochi oggetti raccolti).mp4")
        video.loopPointReached += CheckOver;
        video.Play();

    }


    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadScene("menu_principale");//the scene that you want to load after the video has ended.
    }
}
