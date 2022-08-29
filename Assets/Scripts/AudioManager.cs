using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private List<AudioSource> _bgmAudioSource;
    public bool isAudioEnabled = false;
    private static AudioManager _instance;
    private int _pickedIndex = -1;

    public static AudioManager Instance { get { return _instance; } }
    private void Awake() 
    {   
       if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        } else {
            _instance = this;
            DontDestroyOnLoad(this);
        }
    }
    public void PlayBgm()
    {
        _pickedIndex = Random.Range(0, _bgmAudioSource.Count);
        UnloadUnusedAssets();
        _bgmAudioSource[_pickedIndex].Play();
    }
    public void UnloadUnusedAssets()
    {
        for (int i = 0; i < _bgmAudioSource.Count; i++)
        {
            if (i == _pickedIndex) continue;
            Resources.UnloadAsset(_bgmAudioSource[i].clip);
        }
    }
}
