using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScale : MonoBehaviour {

    void Awake()
    {
            SpriteRenderer sr = (SpriteRenderer)GetComponent("Renderer");

            float width = sr.sprite.bounds.size.x;
            float height = sr.sprite.bounds.size.y;
            float ScreenHeight = Camera.main.orthographicSize * 2.0f;
            float ScreenWidth = ScreenHeight / Screen.height * Screen.width;

            transform.localScale = new Vector2(1 * (ScreenWidth / width), 1 * (ScreenHeight / height));
    }
}
