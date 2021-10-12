using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ShopWindow : EditorWindow
{

    Texture2D headerSectionTexture;
    Texture2D swordSectionTexture;
    Texture2D gunSectionTexture;
    Texture2D potionSectionTexture;

    Color headerSectionColor = new Color(18f / 255, 32f / 255f, 44f / 255f, 1f);

    Rect headerSection;
    Rect swordSection;
    Rect gunSection;
    Rect potionSection;



    [MenuItem("Window/Shop Designer")]
    static void OpenWindow()
    {
        ShopWindow window = (ShopWindow)GetWindow(typeof(ShopWindow));
        window.minSize = new Vector2(600, 300);
        window.Show();
    }

    private void OnEnable()
    {
        InitTextures();
    }

    void InitTextures() //initialize 2D textures
    {
        headerSectionTexture = new Texture2D(1, 1);
        headerSectionTexture.SetPixel(0, 0, headerSectionColor);
        headerSectionTexture.Apply();
    }

    private void OnGUI() //while mouse is over GUI do this
    {
        DrawLayouts();
        DrawHeader();
        DrawSwordSettings();
        DrawGunSettings();
        DrawPotionSettings();
    }

    void DrawLayouts()
    {
        headerSection.x = 0;
        headerSection.y = 0;

        headerSection.width = Screen.width;
        headerSection.height = 50;

        GUI.DrawTexture(headerSection, headerSectionTexture);
    }

    void DrawHeader()
    {

    }

    void DrawSwordSettings()
    {

    }

    void DrawGunSettings()
    {

    }

    void DrawPotionSettings()
    {

    }
}
