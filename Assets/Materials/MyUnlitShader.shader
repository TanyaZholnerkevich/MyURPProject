Shader "Unlit/MyUnlitShader"
{
    Properties
    {
        _Color ("MyColor", Color) = (0.608, 0.420, 0.784, 1)
    }
    SubShader
    {
        Pass
        {
            Cull Front
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            
            #include "UnityCG.cginc"
            float4 _Color;

            struct appdata
            {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };

            struct v2f
            {
                float4 vertex: SV_POSITION;
                float4 color: COLOR;
            };

            v2f vert (appdata v)
            {
                v2f o;
                o.color = dot(_WorldSpaceLightPos0, v.normal);
                o.vertex = UnityObjectToClipPos(v.vertex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                return i.color * _Color;
            }
            ENDCG
        }
    }
}
