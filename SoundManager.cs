using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] BGMArray;
    [SerializeField] private AudioClip[] SEArray;

    private AudioSource audioSourceBGM;
    private AudioSource audioSourceSE;
    [SerializeField] private float audioBGMVolume = 0.1f;
    [SerializeField] private float audioSEVolume = 0.5f;
    // 自身がすでにロードされているかを判定するフラグ
    private static bool isLoad = false;

    // Start update
    void Awake()
    {
        if (isLoad == true)
        {
            Destroy(this.gameObject); // 自分自身を破棄して終了
            return;
        }
        else if (isLoad == false)
        {
            isLoad = true; // ロードされていなかったら、フラグをロード済みに設定する
        }

        DontDestroyOnLoad(this.gameObject);

        foreach (AudioSource audioSource in GetComponents<AudioSource>())
        {
            if (audioSource.loop)
            {
                // BGM用AudioSource
                audioSourceBGM = audioSource;
                audioSourceBGM.volume = audioBGMVolume; // BGM音量設定
                Debug.Log("Find BGM AudioSource");
            }
            else
            {
                // SE用AudioSource
                audioSourceSE = audioSource;
                audioSourceSE.volume = audioSEVolume; // SE音量設定
                Debug.Log("Find SE AudioSource");
            }
        }
    }

    public void BGMPlay(int PlayNmber)
    {
        audioSourceBGM.clip = BGMArray[PlayNmber];
        audioSourceBGM.Play();
    }

    public void SEPlay(int PlayNmber)
    {
        audioSourceSE.clip = SEArray[PlayNmber];
        audioSourceSE.Play();
    }

    public void BGMstop()
    {
        audioSourceBGM.Stop();
    }

    public void SEstop()
    {
        audioSourceSE.Stop();
    }

}
