Shader "Custom/NewSurfaceShader"
{
     Properties {
    _MainTex("Texture", 2D) = "white" {}
  }

  SubShader {
    Pass {
      CGPROGRAM
      #pragma vertex vert_img
      #pragma fragment frag
      #include "UnityCG.cginc" // required for v2f_img

      // Properties
      sampler2D _MainTex;

      float4 frag(v2f_img input) : COLOR {
        // sample texture for color
        float4 base = tex2D(_MainTex, input.uv);
        return base;
      }
      ENDCG
}}}