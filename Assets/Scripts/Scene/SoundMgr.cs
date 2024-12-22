using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMgr : MonoBehaviour
{
    AudioSource Bgm;
    AudioSource Effect;

    private void Awake()
    {
        Shared.SoundMgr = this;//����
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
        //����� ��Ʈ �����ϳ� (���Ұ��Ҷ�)
        //������ ���Ұ� ������ ó������ �ٽ� �帣��
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
