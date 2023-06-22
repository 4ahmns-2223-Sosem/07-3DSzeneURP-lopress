using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumFarbauswahl : MonoBehaviour
{
    public TextMesh textMesh;
    public ColorEnum selectedColor;

    void Start()
    {
        ApplyColor();
    }

    public void OnColorSelected(int colorIndex)
    {
        selectedColor = (ColorEnum)colorIndex;
        ApplyColor();
    }

    private void ApplyColor()
    {
        switch (selectedColor)
        {
            case ColorEnum.Red:
                textMesh.color = Color.red;
                break;
            case ColorEnum.Blue:
                textMesh.color = Color.blue;
                break;
            case ColorEnum.Green:
                textMesh.color = Color.green;
                break;
            case ColorEnum.Yellow:
                textMesh.color = Color.yellow;
                break;
        }
    }
}

public enum ColorEnum
{
    Red,
    Blue,
    Green,
    Yellow
}