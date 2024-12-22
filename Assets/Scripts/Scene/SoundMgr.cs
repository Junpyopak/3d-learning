using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMgr : MonoBehaviour
{
    AudioSource Bgm;
    AudioSource Effect;

    private void Awake()
    {
        Shared.SoundMgr = this;//연결
        DontDestroyOnLoad(this);

        Bgm = transform.Find("Bgm").GetComponent<AudioSource>();
        Bgm.loop = true;

        Effect = transform.Find("Effect").GetComponent<AudioSource>();
    }

    public void PlayBgm(string _Bgm)
    {
        Object obj = Resources.Load(_Bgm);

        if (null == obj)
            return;

        AudioClip clip = obj as AudioClip;

        if (null == clip)
            return;

        Bgm.clip = clip;
        Bgm.Play();
        //스톱과 뮤트 둘중하나 (음소거할때)
        //스톱은 음소거 했을때 처음부터 다시 흐르고
    }
    public void PlayEffect(string _Effect)
    {
        Object obj = Resources.Load(_Effect);

        if (null == obj)
            return;

        AudioClip clip = obj as AudioClip;
        if (null == clip)
            return;
        Effect.PlayOneShot(clip);
    }
}
