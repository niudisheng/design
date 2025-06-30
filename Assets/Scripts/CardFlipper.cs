using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Flasher : MonoBehaviour
{
    private static SpriteOutlineFlash outlineFlash = new SpriteOutlineFlash();

    public static void Flash(Image sr)
    {
        outlineFlash.Flash(sr);
    }
}


public class SpriteOutlineFlash
{
    public float duration = 1f;
    public float maxOutline = 5f; // 取决于 Shader 支持的最大宽度
    public float minOutline = 0f;

    private Material mat;
    private static readonly int Property = Shader.PropertyToID("_OutlineSize");

    public void Flash(SpriteRenderer sr)
    {
        mat = new Material(sr.material); // 实例化材质，避免全局修改
        sr.material = mat;

        // 启动描边动画
        DOTween.To(
                () => mat.GetFloat(Property),
                x => mat.SetFloat(Property, x),
                maxOutline, duration)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.InOutSine);
    }
    public void Flash(Image sr)
    {
        mat = new Material(sr.material); // 实例化材质，避免全局修改
        sr.material = mat;

        // 启动描边动画
        DOTween.To(
                () => mat.GetFloat(Property),
                x => mat.SetFloat(Property, x),
                maxOutline, duration)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.InOutSine);
    }
}