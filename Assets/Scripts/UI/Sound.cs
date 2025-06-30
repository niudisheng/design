using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SoundManager;

public class Sound : MonoBehaviour
{
    public GameObject obj;
    void Awake()
    {
        DontDestroyOnLoad(obj);
    }
    // Start is called before the first frame update
    void Start()
    {
        SoundManager.Instance.playBackgroundMusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
