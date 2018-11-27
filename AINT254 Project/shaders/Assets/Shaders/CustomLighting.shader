Shader "Personal/CustomLighting"
{
	Properties{
		_MainTex("Albedo (RGB)", 2D) = "white" {}
		_Color("Color",Color) = (1,1,1,1)
		_BumpMap("Normal Map")
	}
		SubShader{
		Tags{ "RenderType" = "Opaque" }
		LOD 200

		CGPROGRAM
		#pragma surface surf ISS
		#pragma target 3.0

		sampler2D _MainTex;
		sampler2D _BumpMap;
		fixed4 _Color;

	struct Input
	{
		float2 uv_MainTex;
		float2 uv_BumpMap;
	};

	half4 LightingISS(SurfaceOutput s, half3 lightDir, half3 viewDir, half atten)
	{
		half LdotN = max(-1, dot(lightDir, s.Normal));
		fixed diff = LdotN * 0.5 + 0.2;
		// fixed diff = pow((LdotN * 0.5 + 0.5), 2.0);

		half4 c;
		c.rgb = s.Albedo * diff * _LightColor0.rgb;
		c.a = s.Alpha;
		return c;
	}


	void surf(Input IN, inout SurfaceOutput o)
	{
		fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
		float3 bump = UnpackNormal(tex2D(_BumpMap, IN.uv_BumpMap));

		o.Albedo = c.rgb;
		o.Alpha = c.a;
		o.Normal = bump.rgb;
	}
	ENDCG
	}
		FallBack "Diffuse"
}
