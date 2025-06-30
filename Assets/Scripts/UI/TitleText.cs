using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static SoundManager;

public class TitleText : MonoBehaviour
{
    public GameObject obj;
    public TextMeshProUGUI title;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(obj);
    }
    void Start()
    {
       title.text = "牛首形杆饰"; 
       SoundManager.Instance.playBackgroundMusic();
       
    }

    // Update is called once per frame
    void Update()
    {
    }
}
