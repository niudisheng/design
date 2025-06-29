using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TitleText : MonoBehaviour
{
    public TextMeshProUGUI title;
    // Start is called before the first frame update
    void Start()
    {
       title.text = PlayerPrefs.GetString("Title"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
