using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Rendering.Universal;
using System.Net;

public class MaterialSlide : MonoBehaviour
{
    public List<Material> materials;
    public List<Vector2> offs;

    public UniversalAdditionalLightData skyCookie;

    void Update()
    {
        for (int i = 0; i < materials.Count; i++)
        {
            materials[i].mainTextureOffset += new Vector2(Time.deltaTime * offs[i].x, Time.deltaTime * offs[i].y) / 200;
        }

        skyCookie.lightCookieOffset += new Vector2(Time.deltaTime * 0.5f, Time.deltaTime * 0.73f);
    }
}
