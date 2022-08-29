using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLauncher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (AudioManager.Instance.isAudioEnabled)
        {
            AudioManager.Instance.PlayBgm();
        }
        else
        {
            AudioManager.Instance.UnloadUnusedAssets();
        }
    }

    
}
