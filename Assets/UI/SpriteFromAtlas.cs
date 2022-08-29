using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class SpriteFromAtlas : MonoBehaviour
{
    [SerializeField] SpriteAtlas _atlas;
    [SerializeField] string _imageName;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Image>().sprite = _atlas.GetSprite(_imageName);
    }
}
