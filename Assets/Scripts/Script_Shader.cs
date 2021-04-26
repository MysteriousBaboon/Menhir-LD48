using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class Script_Shader : MonoBehaviour
{
      public Material material;
      public float softness;
      public float radius;

      void Start()
      {
        material.SetFloat("_VSoft", softness);
        material.SetFloat("_VRadius", radius);

      }

  void OnRenderImage (RenderTexture source, RenderTexture destination) {
    Graphics.Blit(source, destination, material);
  }
}
