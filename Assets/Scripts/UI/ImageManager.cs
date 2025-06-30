using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class ImageManager : MonoBehaviour
{
    public Sprite[] imagesToLoad;
    public Image[] imageComponents;

    public List<Image> imageComponentsList;
    // Start is called before the first frame update
    void Start()
    {
        if(imagesToLoad.Length!=imageComponents.Length)
            Debug.LogError("组件和资源数量需一致");
        for (int i = 0; i < imagesToLoad.Length; i++)
        {
            imageComponents[i].sprite = imagesToLoad[i];
        }

    }
    public Image GetImageComponent(int index)
    {
        if (index < 0 || index >= imagesToLoad.Length)
        {
            Debug.LogError("数组溢出");
            return null;
        }
        return imageComponents[index];
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
