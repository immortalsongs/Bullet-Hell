using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBeha : MonoBehaviour
{
    float worldHeight;
    float worldWidth;

    void Awake()
    {

    }

    void GetScreenScal()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        Vector3 temp = transform.localScale;

        float height = sr.bounds.size.y;
        float width = sr.bounds.size.x;

        worldHeight = Camera.main.orthographicSize * 2f;
        worldWidth = worldHeight * Screen.width / Screen.height;
    }

}
