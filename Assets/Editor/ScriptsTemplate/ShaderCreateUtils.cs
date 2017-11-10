using UnityEngine;
using UnityEditor;
using System.Collections;
 
/// <summary>
/// 通过方法"ScriptTemplateGenerator.GenerateShaderTemplete()"自动生成，不要修改该脚本内容
/// </summary>
public class ShaderCreateUtils
{


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Transparent/Bumped Diffuse")]
	static void CreateShader0000()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Alpha-Bumped.shader.txt","New Alpha-Bumped.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Transparent/Bumped Specular")]
	static void CreateShader0001()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Alpha-BumpSpec.shader.txt","New Alpha-BumpSpec.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Transparent/Diffuse")]
	static void CreateShader0002()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Alpha-Diffuse.shader.txt","New Alpha-Diffuse.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Transparent/Specular")]
	static void CreateShader0003()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Alpha-Glossy.shader.txt","New Alpha-Glossy.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Transparent/Parallax Diffuse")]
	static void CreateShader0004()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Alpha-Parallax.shader.txt","New Alpha-Parallax.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Transparent/Parallax Specular")]
	static void CreateShader0005()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Alpha-ParallaxSpec.shader.txt","New Alpha-ParallaxSpec.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Transparent/VertexLit")]
	static void CreateShader0006()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Alpha-VertexLit.shader.txt","New Alpha-VertexLit.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Transparent/Cutout/Bumped Diffuse")]
	static void CreateShader0007()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\AlphaTest-Bumped.shader.txt","New AlphaTest-Bumped.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Transparent/Cutout/Bumped Specular")]
	static void CreateShader0008()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\AlphaTest-BumpSpec.shader.txt","New AlphaTest-BumpSpec.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Transparent/Cutout/Diffuse")]
	static void CreateShader0009()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\AlphaTest-Diffuse.shader.txt","New AlphaTest-Diffuse.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Transparent/Cutout/Specular")]
	static void CreateShader0010()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\AlphaTest-Glossy.shader.txt","New AlphaTest-Glossy.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Transparent/Cutout/Soft Edge Unlit")]
	static void CreateShader0011()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\AlphaTest-SoftEdgeUnlit.shader.txt","New AlphaTest-SoftEdgeUnlit.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Transparent/Cutout/VertexLit")]
	static void CreateShader0012()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\AlphaTest-VertexLit.shader.txt","New AlphaTest-VertexLit.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Decal")]
	static void CreateShader0013()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Decal.shader.txt","New Decal.shader");
	}


	[MenuItem("Assets/Create/Shader/FX/Flare")]
	static void CreateShader0014()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Flare.shader.txt","New Flare.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Self-Illumin/Bumped Diffuse")]
	static void CreateShader0015()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Illumin-Bumped.shader.txt","New Illumin-Bumped.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Self-Illumin/Bumped Specular")]
	static void CreateShader0016()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Illumin-BumpSpec.shader.txt","New Illumin-BumpSpec.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Self-Illumin/Diffuse")]
	static void CreateShader0017()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Illumin-Diffuse.shader.txt","New Illumin-Diffuse.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Self-Illumin/Specular")]
	static void CreateShader0018()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Illumin-Glossy.shader.txt","New Illumin-Glossy.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Self-Illumin/Parallax Diffuse")]
	static void CreateShader0019()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Illumin-Parallax.shader.txt","New Illumin-Parallax.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Self-Illumin/Parallax Specular")]
	static void CreateShader0020()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Illumin-ParallaxSpec.shader.txt","New Illumin-ParallaxSpec.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Self-Illumin/VertexLit")]
	static void CreateShader0021()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Illumin-VertexLit.shader.txt","New Illumin-VertexLit.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/BlitCopy")]
	static void CreateShader0022()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Internal-BlitCopy.shader.txt","New Internal-BlitCopy.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/BlitCopyDepth")]
	static void CreateShader0023()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Internal-BlitCopyDepth.shader.txt","New Internal-BlitCopyDepth.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/Internal-CombineDepthNormals")]
	static void CreateShader0024()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Internal-CombineDepthNormals.shader.txt","New Internal-CombineDepthNormals.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/ConvertTexture")]
	static void CreateShader0025()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Internal-ConvertTexture.shader.txt","New Internal-ConvertTexture.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/Internal-DeferredReflections")]
	static void CreateShader0026()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Internal-DeferredReflections.shader.txt","New Internal-DeferredReflections.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/Internal-DeferredShading")]
	static void CreateShader0027()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Internal-DeferredShading.shader.txt","New Internal-DeferredShading.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/Internal-DepthNormalsTexture")]
	static void CreateShader0028()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Internal-DepthNormalsTexture.shader.txt","New Internal-DepthNormalsTexture.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/Internal-Flare")]
	static void CreateShader0029()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Internal-Flare.shader.txt","New Internal-Flare.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/Internal-GUITexture")]
	static void CreateShader0030()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Internal-GUITexture.shader.txt","New Internal-GUITexture.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/Internal-GUITextureBlit")]
	static void CreateShader0031()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Internal-GUITextureBlit.shader.txt","New Internal-GUITextureBlit.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/Internal-GUITextureClip")]
	static void CreateShader0032()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Internal-GUITextureClip.shader.txt","New Internal-GUITextureClip.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/Internal-GUITextureClipText")]
	static void CreateShader0033()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Internal-GUITextureClipText.shader.txt","New Internal-GUITextureClipText.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/Internal-Halo")]
	static void CreateShader0034()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Internal-Halo.shader.txt","New Internal-Halo.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/Internal-MotionVectors")]
	static void CreateShader0035()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Internal-MotionVectors.shader.txt","New Internal-MotionVectors.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/Internal-PrePassLighting")]
	static void CreateShader0036()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Internal-PrePassLighting.shader.txt","New Internal-PrePassLighting.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/Internal-ScreenSpaceShadows")]
	static void CreateShader0037()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Internal-ScreenSpaceShadows.shader.txt","New Internal-ScreenSpaceShadows.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/Internal-StencilWrite")]
	static void CreateShader0038()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Internal-StencilWrite.shader.txt","New Internal-StencilWrite.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Lightmapped/Bumped Diffuse")]
	static void CreateShader0039()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Lightmap-Bumped.shader.txt","New Lightmap-Bumped.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Lightmapped/Bumped Specular")]
	static void CreateShader0040()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Lightmap-BumpSpec.shader.txt","New Lightmap-BumpSpec.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Lightmapped/Diffuse")]
	static void CreateShader0041()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Lightmap-Diffuse.shader.txt","New Lightmap-Diffuse.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Lightmapped/Specular")]
	static void CreateShader0042()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Lightmap-Glossy.shader.txt","New Lightmap-Glossy.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Lightmapped/VertexLit")]
	static void CreateShader0043()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Lightmap-VertexLit.shader.txt","New Lightmap-VertexLit.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Bumped Diffuse")]
	static void CreateShader0044()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Normal-Bumped.shader.txt","New Normal-Bumped.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Bumped Specular")]
	static void CreateShader0045()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Normal-BumpSpec.shader.txt","New Normal-BumpSpec.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Diffuse")]
	static void CreateShader0046()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Normal-Diffuse.shader.txt","New Normal-Diffuse.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Diffuse Detail")]
	static void CreateShader0047()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Normal-DiffuseDetail.shader.txt","New Normal-DiffuseDetail.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Diffuse Fast")]
	static void CreateShader0048()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Normal-DiffuseFast.shader.txt","New Normal-DiffuseFast.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Specular")]
	static void CreateShader0049()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Normal-Glossy.shader.txt","New Normal-Glossy.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Parallax Diffuse")]
	static void CreateShader0050()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Normal-Parallax.shader.txt","New Normal-Parallax.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Parallax Specular")]
	static void CreateShader0051()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Normal-ParallaxSpec.shader.txt","New Normal-ParallaxSpec.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/VertexLit")]
	static void CreateShader0052()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Normal-VertexLit.shader.txt","New Normal-VertexLit.shader");
	}


	[MenuItem("Assets/Create/Shader/Particles/Additive")]
	static void CreateShader0053()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Particle Add.shader.txt","New Particle Add.shader");
	}


	[MenuItem("Assets/Create/Shader/Particles/~Additive-Multiply")]
	static void CreateShader0054()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Particle AddMultiply.shader.txt","New Particle AddMultiply.shader");
	}


	[MenuItem("Assets/Create/Shader/Particles/Additive (Soft)")]
	static void CreateShader0055()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Particle AddSmooth.shader.txt","New Particle AddSmooth.shader");
	}


	[MenuItem("Assets/Create/Shader/Particles/Alpha Blended")]
	static void CreateShader0056()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Particle Alpha Blend.shader.txt","New Particle Alpha Blend.shader");
	}


	[MenuItem("Assets/Create/Shader/Particles/Anim Alpha Blended")]
	static void CreateShader0057()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Particle Anim Alpha Blend.shader.txt","New Particle Anim Alpha Blend.shader");
	}


	[MenuItem("Assets/Create/Shader/Particles/Blend")]
	static void CreateShader0058()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Particle Blend.shader.txt","New Particle Blend.shader");
	}


	[MenuItem("Assets/Create/Shader/Particles/Multiply")]
	static void CreateShader0059()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Particle Multiply.shader.txt","New Particle Multiply.shader");
	}


	[MenuItem("Assets/Create/Shader/Particles/Multiply (Double)")]
	static void CreateShader0060()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Particle MultiplyDouble.shader.txt","New Particle MultiplyDouble.shader");
	}


	[MenuItem("Assets/Create/Shader/Particles/Alpha Blended Premultiply")]
	static void CreateShader0061()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Particle Premultiply Blend.shader.txt","New Particle Premultiply Blend.shader");
	}


	[MenuItem("Assets/Create/Shader/Particles/VertexLit Blended")]
	static void CreateShader0062()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Particle VertexLit Blended.shader.txt","New Particle VertexLit Blended.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Reflective/Bumped Diffuse")]
	static void CreateShader0063()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Reflect-Bumped.shader.txt","New Reflect-Bumped.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Reflective/Bumped Unlit")]
	static void CreateShader0064()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Reflect-BumpNolight.shader.txt","New Reflect-BumpNolight.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Reflective/Bumped Specular")]
	static void CreateShader0065()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Reflect-BumpSpec.shader.txt","New Reflect-BumpSpec.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Reflective/Bumped VertexLit")]
	static void CreateShader0066()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Reflect-BumpVertexLit.shader.txt","New Reflect-BumpVertexLit.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Reflective/Diffuse")]
	static void CreateShader0067()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Reflect-Diffuse.shader.txt","New Reflect-Diffuse.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Reflective/Specular")]
	static void CreateShader0068()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Reflect-Glossy.shader.txt","New Reflect-Glossy.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Reflective/Parallax Diffuse")]
	static void CreateShader0069()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Reflect-Parallax.shader.txt","New Reflect-Parallax.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Reflective/Parallax Specular")]
	static void CreateShader0070()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Reflect-ParallaxSpec.shader.txt","New Reflect-ParallaxSpec.shader");
	}


	[MenuItem("Assets/Create/Shader/Legacy Shaders/Reflective/VertexLit")]
	static void CreateShader0071()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Reflect-VertexLit.shader.txt","New Reflect-VertexLit.shader");
	}


	[MenuItem("Assets/Create/Shader/Skybox/Cubemap")]
	static void CreateShader0072()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Skybox-Cubed.shader.txt","New Skybox-Cubed.shader");
	}


	[MenuItem("Assets/Create/Shader/Skybox/Procedural")]
	static void CreateShader0073()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Skybox-Procedural.shader.txt","New Skybox-Procedural.shader");
	}


	[MenuItem("Assets/Create/Shader/Skybox/6 Sided")]
	static void CreateShader0074()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Skybox.shader.txt","New Skybox.shader");
	}


	[MenuItem("Assets/Create/Shader/Sprites/Default")]
	static void CreateShader0075()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Sprites-Default.shader.txt","New Sprites-Default.shader");
	}


	[MenuItem("Assets/Create/Shader/Sprites/Diffuse")]
	static void CreateShader0076()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Sprites-Diffuse.shader.txt","New Sprites-Diffuse.shader");
	}


	[MenuItem("Assets/Create/Shader/Standard")]
	static void CreateShader0077()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Standard.shader.txt","New Standard.shader");
	}


	[MenuItem("Assets/Create/Shader/Standard (Specular setup)")]
	static void CreateShader0078()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\StandardSpecular.shader.txt","New StandardSpecular.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/VideoDecode")]
	static void CreateShader0079()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\VideoDecode.shader.txt","New VideoDecode.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/VideoDecodeAndroid")]
	static void CreateShader0080()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\VideoDecodeAndroid.shader.txt","New VideoDecodeAndroid.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/VideoDecodeOSX")]
	static void CreateShader0081()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\VideoDecodeOSX.shader.txt","New VideoDecodeOSX.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/CubeBlend")]
	static void CreateShader0082()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Cubemaps\CubeBlend.shader.txt","New CubeBlend.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/CubeBlur")]
	static void CreateShader0083()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Cubemaps\CubeBlur.shader.txt","New CubeBlur.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/CubeBlurOdd")]
	static void CreateShader0084()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Cubemaps\CubeBlurOdd.shader.txt","New CubeBlurOdd.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/CubeCopy")]
	static void CreateShader0085()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Cubemaps\CubeCopy.shader.txt","New CubeCopy.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/GIDebug/ShowLightMask")]
	static void CreateShader0086()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\GIDebug\ShowLightMask.shader.txt","New ShowLightMask.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/GIDebug/TextureUV")]
	static void CreateShader0087()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\GIDebug\TextureUV.shader.txt","New TextureUV.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/GIDebug/UV1sAsPositions")]
	static void CreateShader0088()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\GIDebug\UV1sAsPositions.shader.txt","New UV1sAsPositions.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/GIDebug/VertexColors")]
	static void CreateShader0089()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\GIDebug\VertexColors.shader.txt","New VertexColors.shader");
	}


	[MenuItem("Assets/Create/Shader/Mobile/Bumped Diffuse")]
	static void CreateShader0090()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Mobile\Mobile-Bumped.shader.txt","New Mobile-Bumped.shader");
	}


	[MenuItem("Assets/Create/Shader/Mobile/Bumped Specular (1 Directional Light)")]
	static void CreateShader0091()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Mobile\Mobile-BumpSpec-1DirectionalLight.shader.txt","New Mobile-BumpSpec-1DirectionalLight.shader");
	}


	[MenuItem("Assets/Create/Shader/Mobile/Bumped Specular")]
	static void CreateShader0092()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Mobile\Mobile-BumpSpec.shader.txt","New Mobile-BumpSpec.shader");
	}


	[MenuItem("Assets/Create/Shader/Mobile/Diffuse")]
	static void CreateShader0093()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Mobile\Mobile-Diffuse.shader.txt","New Mobile-Diffuse.shader");
	}


	[MenuItem("Assets/Create/Shader/Mobile/Unlit (Supports Lightmap)")]
	static void CreateShader0094()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Mobile\Mobile-Lightmap-Unlit.shader.txt","New Mobile-Lightmap-Unlit.shader");
	}


	[MenuItem("Assets/Create/Shader/Mobile/Particles/Additive")]
	static void CreateShader0095()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Mobile\Mobile-Particle-Add.shader.txt","New Mobile-Particle-Add.shader");
	}


	[MenuItem("Assets/Create/Shader/Mobile/Particles/VertexLit Blended")]
	static void CreateShader0096()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Mobile\Mobile-Particle-Alpha-VertexLit.shader.txt","New Mobile-Particle-Alpha-VertexLit.shader");
	}


	[MenuItem("Assets/Create/Shader/Mobile/Particles/Alpha Blended")]
	static void CreateShader0097()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Mobile\Mobile-Particle-Alpha.shader.txt","New Mobile-Particle-Alpha.shader");
	}


	[MenuItem("Assets/Create/Shader/Mobile/Particles/Multiply")]
	static void CreateShader0098()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Mobile\Mobile-Particle-Multiply.shader.txt","New Mobile-Particle-Multiply.shader");
	}


	[MenuItem("Assets/Create/Shader/Mobile/Skybox")]
	static void CreateShader0099()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Mobile\Mobile-Skybox.shader.txt","New Mobile-Skybox.shader");
	}


	[MenuItem("Assets/Create/Shader/Mobile/VertexLit (Only Directional Lights)")]
	static void CreateShader0100()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Mobile\Mobile-VertexLit-OnlyDirectionalLights.shader.txt","New Mobile-VertexLit-OnlyDirectionalLights.shader");
	}


	[MenuItem("Assets/Create/Shader/Mobile/VertexLit")]
	static void CreateShader0101()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Mobile\Mobile-VertexLit.shader.txt","New Mobile-VertexLit.shader");
	}


	[MenuItem("Assets/Create/Shader/Nature/SpeedTree")]
	static void CreateShader0102()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Nature\SpeedTree.shader.txt","New SpeedTree.shader");
	}


	[MenuItem("Assets/Create/Shader/Nature/SpeedTree Billboard")]
	static void CreateShader0103()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Nature\SpeedTreeBillboard.shader.txt","New SpeedTreeBillboard.shader");
	}


	[MenuItem("Assets/Create/Shader/Nature/Tree Soft Occlusion Bark")]
	static void CreateShader0104()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Nature\SoftOcclusion\TreeSoftOcclusionBark.shader.txt","New TreeSoftOcclusionBark.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/Nature/Tree Soft Occlusion Bark Rendertex")]
	static void CreateShader0105()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Nature\SoftOcclusion\TreeSoftOcclusionBarkRendertex.shader.txt","New TreeSoftOcclusionBarkRendertex.shader");
	}


	[MenuItem("Assets/Create/Shader/Nature/Tree Soft Occlusion Leaves")]
	static void CreateShader0106()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Nature\SoftOcclusion\TreeSoftOcclusionLeaves.shader.txt","New TreeSoftOcclusionLeaves.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/Nature/Tree Soft Occlusion Leaves Rendertex")]
	static void CreateShader0107()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Nature\SoftOcclusion\TreeSoftOcclusionLeavesRendertex.shader.txt","New TreeSoftOcclusionLeavesRendertex.shader");
	}


	[MenuItem("Assets/Create/Shader/Nature/Tree Creator Bark")]
	static void CreateShader0108()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Nature\TreeCreator\TreeCreatorBark.shader.txt","New TreeCreatorBark.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/Nature/Tree Creator Bark Optimized")]
	static void CreateShader0109()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Nature\TreeCreator\TreeCreatorBarkOptimized.shader.txt","New TreeCreatorBarkOptimized.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/Nature/Tree Creator Bark Rendertex")]
	static void CreateShader0110()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Nature\TreeCreator\TreeCreatorBarkRendertex.shader.txt","New TreeCreatorBarkRendertex.shader");
	}


	[MenuItem("Assets/Create/Shader/Nature/Tree Creator Leaves")]
	static void CreateShader0111()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Nature\TreeCreator\TreeCreatorLeaves.shader.txt","New TreeCreatorLeaves.shader");
	}


	[MenuItem("Assets/Create/Shader/Nature/Tree Creator Leaves Fast")]
	static void CreateShader0112()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Nature\TreeCreator\TreeCreatorLeavesFast.shader.txt","New TreeCreatorLeavesFast.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/Nature/Tree Creator Leaves Fast Optimized")]
	static void CreateShader0113()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Nature\TreeCreator\TreeCreatorLeavesFastOptimized.shader.txt","New TreeCreatorLeavesFastOptimized.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/Nature/Tree Creator Leaves Optimized")]
	static void CreateShader0114()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Nature\TreeCreator\TreeCreatorLeavesOptimized.shader.txt","New TreeCreatorLeavesOptimized.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/Nature/Tree Creator Leaves Rendertex")]
	static void CreateShader0115()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Nature\TreeCreator\TreeCreatorLeavesRendertex.shader.txt","New TreeCreatorLeavesRendertex.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/TerrainEngine/Details/Vertexlit")]
	static void CreateShader0116()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\TerrainShaders\Details\VertexLit.shader.txt","New VertexLit.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/TerrainEngine/Details/WavingDoublePass")]
	static void CreateShader0117()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\TerrainShaders\Details\WavingGrass.shader.txt","New WavingGrass.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/TerrainEngine/Details/BillboardWavingDoublePass")]
	static void CreateShader0118()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\TerrainShaders\Details\WavingGrassBillboard.shader.txt","New WavingGrassBillboard.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/TerrainEngine/Splatmap/Diffuse-AddPass")]
	static void CreateShader0119()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\TerrainShaders\Splats\AddPass.shader.txt","New AddPass.shader");
	}


	[MenuItem("Assets/Create/Shader/Nature/Terrain/Diffuse")]
	static void CreateShader0120()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\TerrainShaders\Splats\FirstPass.shader.txt","New FirstPass.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/TerrainEngine/Splatmap/Specular-AddPass")]
	static void CreateShader0121()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\TerrainShaders\Splats\Specular-AddPass.shader.txt","New Specular-AddPass.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/TerrainEngine/Splatmap/Specular-Base")]
	static void CreateShader0122()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\TerrainShaders\Splats\Specular-Base.shader.txt","New Specular-Base.shader");
	}


	[MenuItem("Assets/Create/Shader/Nature/Terrain/Specular")]
	static void CreateShader0123()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\TerrainShaders\Splats\Specular-FirstPass.shader.txt","New Specular-FirstPass.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/TerrainEngine/Splatmap/Standard-AddPass")]
	static void CreateShader0124()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\TerrainShaders\Splats\Standard-AddPass.shader.txt","New Standard-AddPass.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/TerrainEngine/Splatmap/Standard-Base")]
	static void CreateShader0125()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\TerrainShaders\Splats\Standard-Base.shader.txt","New Standard-Base.shader");
	}


	[MenuItem("Assets/Create/Shader/Nature/Terrain/Standard")]
	static void CreateShader0126()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\TerrainShaders\Splats\Standard-FirstPass.shader.txt","New Standard-FirstPass.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/TerrainEngine/BillboardTree")]
	static void CreateShader0127()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\TerrainShaders\Trees\BillboardTree.shader.txt","New BillboardTree.shader");
	}


	[MenuItem("Assets/Create/Shader/UI/Default")]
	static void CreateShader0128()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\UI\UI-Default.shader.txt","New UI-Default.shader");
	}


	[MenuItem("Assets/Create/Shader/UI/DefaultETC1")]
	static void CreateShader0129()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\UI\UI-DefaultETC1.shader.txt","New UI-DefaultETC1.shader");
	}


	[MenuItem("Assets/Create/Shader/UI/Default Font")]
	static void CreateShader0130()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\UI\UI-DefaultFont.shader.txt","New UI-DefaultFont.shader");
	}


	[MenuItem("Assets/Create/Shader/UI/Lit/Bumped")]
	static void CreateShader0131()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\UI\UI-Lit-Bumped.shader.txt","New UI-Lit-Bumped.shader");
	}


	[MenuItem("Assets/Create/Shader/UI/Lit/Detail")]
	static void CreateShader0132()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\UI\UI-Lit-Detail.shader.txt","New UI-Lit-Detail.shader");
	}


	[MenuItem("Assets/Create/Shader/UI/Lit/Refraction")]
	static void CreateShader0133()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\UI\UI-Lit-Refraction.shader.txt","New UI-Lit-Refraction.shader");
	}


	[MenuItem("Assets/Create/Shader/UI/Lit/Refraction Detail")]
	static void CreateShader0134()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\UI\UI-Lit-RefractionDetail.shader.txt","New UI-Lit-RefractionDetail.shader");
	}


	[MenuItem("Assets/Create/Shader/UI/Lit/Transparent")]
	static void CreateShader0135()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\UI\UI-Lit-Transparent.shader.txt","New UI-Lit-Transparent.shader");
	}


	[MenuItem("Assets/Create/Shader/UI/Unlit/Detail")]
	static void CreateShader0136()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\UI\UI-Unlit-Detail.shader.txt","New UI-Unlit-Detail.shader");
	}


	[MenuItem("Assets/Create/Shader/UI/Unlit/Text")]
	static void CreateShader0137()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\UI\UI-Unlit-Text.shader.txt","New UI-Unlit-Text.shader");
	}


	[MenuItem("Assets/Create/Shader/UI/Unlit/Text Detail")]
	static void CreateShader0138()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\UI\UI-Unlit-TextDetail.shader.txt","New UI-Unlit-TextDetail.shader");
	}


	[MenuItem("Assets/Create/Shader/UI/Unlit/Transparent")]
	static void CreateShader0139()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\UI\UI-Unlit-Transparent.shader.txt","New UI-Unlit-Transparent.shader");
	}


	[MenuItem("Assets/Create/Shader/Unlit/Transparent")]
	static void CreateShader0140()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Unlit\Unlit-Alpha.shader.txt","New Unlit-Alpha.shader");
	}


	[MenuItem("Assets/Create/Shader/Unlit/Transparent Cutout")]
	static void CreateShader0141()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Unlit\Unlit-AlphaTest.shader.txt","New Unlit-AlphaTest.shader");
	}


	[MenuItem("Assets/Create/Shader/Unlit/Color")]
	static void CreateShader0142()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Unlit\Unlit-Color.shader.txt","New Unlit-Color.shader");
	}


	[MenuItem("Assets/Create/Shader/Unlit/Texture")]
	static void CreateShader0143()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\Unlit\Unlit-Normal.shader.txt","New Unlit-Normal.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/VR/BlitCopyFromTexArray")]
	static void CreateShader0144()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\VR\Shaders\BlitCopyFromTexArray.shader.txt","New BlitCopyFromTexArray.shader");
	}


	[MenuItem("Assets/Create/Shader/Hidden/VR/Internal-VRDistortion")]
	static void CreateShader0145()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\VR\Shaders\Internal-VRDistortion.shader.txt","New Internal-VRDistortion.shader");
	}


	[MenuItem("Assets/Create/Shader/VR/SpatialMapping/Occlusion")]
	static void CreateShader0146()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\VR\Shaders\SpatialMappingOcclusion.shader.txt","New SpatialMappingOcclusion.shader");
	}


	[MenuItem("Assets/Create/Shader/VR/SpatialMapping/Wireframe")]
	static void CreateShader0147()
	{
		ProjectWindowUtilEx.CreateScriptUtil(@"Templates\Shaders\VR\Shaders\SpatialMappingWireframe.shader.txt","New SpatialMappingWireframe.shader");
	}
}
