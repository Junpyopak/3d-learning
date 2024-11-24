using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public partial class UI_TITLE : MonoBehaviour
{
    
    public VideoPlayer VIDEOPLAYER;
    public RawImage RAWIMG;

    VideoClip Clip = null;


    void SetVideo()
    {
        string file = "Prefabs/Video/" + "EF_Normal";

        Clip = Resources.Load(file) as VideoClip;
        VIDEOPLAYER.gameObject.SetActive(true);

        //RAWIMG.texture = VIDEOPLAYER.targetTexture;
        RAWIMG.texture = VIDEOPLAYER.texture;

        VIDEOPLAYER.clip = Clip;

       VIDEOPLAYER.Prepare();

       StartCoroutine(IUpadateVideo());
    }
    IEnumerator IUpadateVideo()
    {
        VIDEOPLAYER.Play();
        yield return new WaitForSeconds(0.1f);

        while (true)
        {
            yield return new WaitForSeconds(0.1f);

            if(true==VIDEOPLAYER.isPlaying)
            {
                RAWIMG.texture= VIDEOPLAYER.texture;

                continue;
            }
            break;
        }
        VIDEOPLAYER.transform.gameObject.SetActive(false);
    }
}
