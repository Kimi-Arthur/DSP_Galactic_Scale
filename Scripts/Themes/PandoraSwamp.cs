using System.Collections.Generic;
using UnityEngine;

namespace GalacticScale
{
    public static partial class Themes
    {
        public static GSTheme PandoraSwamp = new()
        {
            Name = "PandoraSwamp",
            Base = true,
            DisplayName = "Pandora Swamp".Translate(),
            PlanetType = EPlanetType.Ocean,
            ThemeType = EThemeType.Telluric,
            BriefIntroduction = "潘多拉沼泽介绍A",
            Eigenbit = 19,
            LDBThemeId = 25,
            Algo = 13,
            MinRadius = 5,
            MaxRadius = 510,
            MaterialPath = "Universe/Materials/Planets/Desert 11/",
            Temperature = 0f,
            Distribute = EThemeDistribute.Interstellar,
            Habitable = false,
            ModX = new Vector2(1f, 1f),
            ModY = new Vector2(3f, 3f),
            VeinSettings = new GSVeinSettings
            {
                Algorithm = "Vanilla",
                VeinTypes = new GSVeinTypes()
            },
//AmbientSettings 1
            AmbientSettings = new GSAmbientSettings
            {
                Color1 = new Color(0.117647f, 0.06905881f, 0.1117054f, 1f),
                Color2 = new Color(0.1498965f, 0.1110345f, 0.322f, 1f),
                Color3 = new Color(0.0642857f, 0.133404f, 0.33f, 1f),
                WaterColor1 = new Color(0f, 0f, 0f, 1f),
                WaterColor2 = new Color(0f, 0f, 0f, 1f),
                WaterColor3 = new Color(0f, 0f, 0f, 1f),
                BiomeColor1 = new Color(0.1058824f, 0.2078432f, 0.3019608f, 1f),
                BiomeColor2 = new Color(0f, 0.2924528f, 0.2297844f, 1f),
                BiomeColor3 = new Color(0.08566215f, 0.6378558f, 0.7264151f, 1f),
                DustColor1 = new Color(0.1483179f, 0.2328379f, 0.3113208f, 0f),
                DustColor2 = new Color(0.3098039f, 0.6588235f, 0.5179729f, 0.8f),
                DustColor3 = new Color(0.5977661f, 0.9046117f, 0.9528302f, 0.5019608f),
                DustStrength1 = 0f,
                DustStrength2 = 5f,
                DustStrength3 = 6f,
                BiomeSound1 = 1,
                BiomeSound2 = 0,
                BiomeSound3 = 2,
                CubeMap = "Vanilla",
                Reflections = new Color(),
                LutContribution = 0.6f
            },
            Vegetables0 = new[]
            {
                681,
                682,
                683,
                684,
                685,
                151,
                148,
                149,
                1085
            },
            Vegetables1 = new[]
            {
                1085,
                681,
                142,
                685,
                143,
                682,
                1086,
                144,
                150
            },
            Vegetables2 = new[]
            {
                1084,
                1081,
                1082,
                1083,
                1085,
                1086
            },
            Vegetables3 = new[]
            {
                141,
                145
            },
            Vegetables4 = new[]
            {
                1084,
                681,
                682,
                683,
                684,
                1086,
                685,
                146,
                147
            },
            Vegetables5 = new int[]
            {
            },
            VeinSpot = new[]
            {
                8,
                3,
                8,
                1,
                3,
                9,
                20
            },
            VeinCount = new[]
            {
                0.7f,
                0.6f,
                1f,
                1f,
                0.6f,
                1f,
                1f
            },
            VeinOpacity = new[]
            {
                0.7f,
                0.5f,
                1f,
                1f,
                0.7f,
                1.2f,
                1f
            },
            RareVeins = new[]
            {
                10,
                11,
                13
            },
            RareSettings = new[]
            {
                0f,
                0.5f,
                0.3f,
                1f,
                0f,
                1f,
                0.3f,
                1f,
                0f,
                0.5f,
                0.2f,
                1f
            },
            GasItems = new int[]
            {
            },
            GasSpeeds = new float[]
            {
            },
            UseHeightForBuild = false,
            Wind = 1f,
            IonHeight = 60f,
            WaterHeight = -2f,
            WaterItemId = 0,
            Musics = new[]
            {
                15,
                16
            },
            SFXPath = "SFX/sfx-amb-ocean-3",
            SFXVolume = 1f,
            CullingRadius = 0f,
            atmosphereMaterial = new GSMaterialSettings
            {
                Colors = new Dictionary<string, Color>
                {
                    ["_Color"] = new(0.3443396f, 0.734796f, 1f, 1f),
                    ["_Color0"] = new(0.1645661f, 0f, 0.7830188f, 1f),
                    ["_Color1"] = new(0.2600924f, 0.119168f, 0.608f, 1f),
                    ["_Color2"] = new(0.197331f, 0.3874864f, 0.5309999f, 1f),
                    ["_Color3"] = new(0.2177699f, 0.5099999f, 0.4216339f, 1f),
                    ["_Color4"] = new(0.9355401f, 0.7737787f, 0.4597946f, 1f),
                    ["_Color5"] = new(0.3682136f, 0f, 1f, 1f),
                    ["_Color6"] = new(0.4831462f, 0f, 1f, 1f),
                    ["_Color7"] = new(0.6027341f, 0f, 1f, 1f),
                    ["_Color8"] = new(0.5896226f, 1f, 0.8227582f, 1f),
                    ["_ColorF"] = new(1f, 0.7466807f, 0.6462264f, 1f),
                    ["_EmissionColor"] = new(0f, 0f, 0f, 1f),
                    ["_LocalPos"] = new(12.67476f, 14.58858f, -199.0018f, 0f),
                    ["_PlanetPos"] = new(0f, 0f, 0f, 0f),
                    ["_PlanetRadius"] = new(200f, 100f, 260f, 0f),
                    ["_Sky0"] = new(0.2891151f, 0.6353433f, 0.6886792f, 0.8470588f),
                    ["_Sky1"] = new(0.3884041f, 0.2713152f, 0.6320754f, 0.6784314f),
                    ["_Sky2"] = new(0.3098039f, 0.6235294f, 0.4783867f, 0.8823529f),
                    ["_Sky3"] = new(0.1215683f, 0.2313723f, 0.6470588f, 0.7568628f),
                    ["_Sky4"] = new(0.9758275f, 0.8632414f, 0.5395815f, 1f)
                },
                Params = new Dictionary<string, float>
                {
                    ["_AtmoDensity"] = 1.1f,
                    ["_AtmoThickness"] = 70f,
                    ["_BumpScale"] = 1f,
                    ["_Cutoff"] = 0.5f,
                    ["_Density"] = 0.005f,
                    ["_DetailNormalMapScale"] = 1f,
                    ["_DistanceControl"] = 0f,
                    ["_DstBlend"] = 0f,
                    ["_FarFogDensity"] = 0.3f,
                    ["_FogDensity"] = 0.3f,
                    ["_FogSaturate"] = 0.7f,
                    ["_GlossMapScale"] = 1f,
                    ["_Glossiness"] = 0.5f,
                    ["_GlossyReflections"] = 1f,
                    ["_GroundAtmosPower"] = 3f,
                    ["_Intensity"] = 1f,
                    ["_IntensityControl"] = 1f,
                    ["_Metallic"] = 0f,
                    ["_Mode"] = 0f,
                    ["_OcclusionStrength"] = 1f,
                    ["_Parallax"] = 0.02f,
                    ["_RimFogExp"] = 1f,
                    ["_RimFogPower"] = 1f,
                    ["_SkyAtmosPower"] = 8f,
                    ["_SmoothnessTextureChannel"] = 0f,
                    ["_SpecularHighlights"] = 1f,
                    ["_SrcBlend"] = 1f,
                    ["_StencilComp"] = 8f,
                    ["_StencilRef"] = 0f,
                    ["_SunColorAdd"] = 1f,
                    ["_SunColorSkyUse"] = 1f,
                    ["_SunColorUse"] = 1f,
                    ["_SunRiseScatterPower"] = 60f,
                    ["_UVSec"] = 0f,
                    ["_ZWrite"] = 1f
                }
            },
            minimapMaterial = new GSMaterialSettings
            {
                Colors = new Dictionary<string, Color>
                {
                    ["_Color"] = new(0.1098039f, 0.1764705f, 0.3215686f, 1f),
                    ["_ColorBio0"] = new(0.1058822f, 0.207843f, 0.3019607f, 1f),
                    ["_ColorBio1"] = new(0.2235293f, 0.4313725f, 0.3882352f, 1f),
                    ["_ColorBio2"] = new(0.235294f, 0.7215686f, 0.7960785f, 1f),
                    ["_EmissionColor"] = new(0f, 0f, 0f, 1f),
                    ["_HeightSettings"] = new(-0.1f, 0.3f, 0.1f, 0.1f),
                    ["_RimColor"] = new(0f, 0.4225275f, 1f, 1f),
                    ["_ShoreLineColor"] = new(0f, 0f, 0f, 0f)
                },
                Params = new Dictionary<string, float>
                {
                    ["_BioStrength"] = 0.6f,
                    ["_BumpScale"] = 1f,
                    ["_Cutoff"] = 0.5f,
                    ["_DetailNormalMapScale"] = 1f,
                    ["_DstBlend"] = 0f,
                    ["_GlossMapScale"] = 1f,
                    ["_Glossiness"] = 0.5f,
                    ["_GlossyReflections"] = 1f,
                    ["_Metallic"] = 0f,
                    ["_Mode"] = 0f,
                    ["_OcclusionStrength"] = 1f,
                    ["_Parallax"] = 0.02f,
                    ["_ShoreHeight"] = 0f,
                    ["_ShoreInvThick"] = 13f,
                    ["_SmoothnessTextureChannel"] = 0f,
                    ["_SpecularHighlights"] = 1f,
                    ["_SrcBlend"] = 1f,
                    ["_UVSec"] = 0f,
                    ["_WireIntens"] = 0.6f,
                    ["_ZWrite"] = 1f
                }
            },
            terrainMaterial = new GSMaterialSettings
            {
                Colors = new Dictionary<string, Color>
                {
                    ["_AmbientColor0"] = new(0.117647f, 0.06905881f, 0.1117054f, 1f),
                    ["_AmbientColor1"] = new(0.1498965f, 0.1110345f, 0.322f, 1f),
                    ["_AmbientColor2"] = new(0.0642857f, 0.133404f, 0.33f, 1f),
                    ["_Color"] = new(1f, 1f, 1f, 1f),
                    ["_EmissionColor"] = new(0f, 0f, 0f, 1f),
                    ["_GICloudColor"] = new(1f, 0.7647059f, 0f, 1f),
                    ["_HeightEmissionColor"] = new(0f, 0f, 0f, 0f),
                    ["_LightColorScreen"] = new(0.4745096f, 0f, 1f, 1f),
                    ["_Rotation"] = new(0f, 0f, 0f, 1f),
                    ["_ShiftColor"] = new(0.8962264f, 0.8500136f, 0.2494215f, 0.6509804f),
                    ["_SpeclColor"] = new(0.3394594f, 0.3529412f, 0.04447056f, 0.854902f),
                    ["_SunDir"] = new(0.9884955f, 0.1340293f, 0.07009208f, 0f)
                },
                Params = new Dictionary<string, float>
                {
                    ["_AmbientInc"] = 0.5f,
                    ["_BioFuzzMask"] = 1f,
                    ["_BioFuzzStrength"] = 0f,
                    ["_BumpScale"] = 1f,
                    ["_Cutoff"] = 0.5f,
                    ["_DetailNormalMapScale"] = 1f,
                    ["_Distance"] = 220.014f,
                    ["_DstBlend"] = 0f,
                    ["_EmissionStrength"] = 0f,
                    ["_GICloudStrength"] = 1f,
                    ["_GISaturate"] = 0.67f,
                    ["_GIStrengthDay"] = 0.256f,
                    ["_GIStrengthNight"] = 0.055f,
                    ["_GlossMapScale"] = 1f,
                    ["_Glossiness"] = 0.5f,
                    ["_GlossyReflections"] = 1f,
                    ["_HeightEmissionRadius"] = 50f,
                    ["_Metallic"] = 0f,
                    ["_Mode"] = 0f,
                    ["_Multiplier"] = 1.8f,
                    ["_NormalStrength"] = 0.6f,
                    ["_OcclusionStrength"] = 1f,
                    ["_Parallax"] = 0.02f,
                    ["_Radius"] = 200f,
                    ["_ShiftPower"] = 1.26f,
                    ["_ShiftThres"] = 1f,
                    ["_SmoothnessTextureChannel"] = 0f,
                    ["_SpecularHighlights"] = 1f,
                    ["_SrcBlend"] = 1f,
                    ["_StepBlend"] = 1f,
                    ["_UVSec"] = 0f,
                    ["_ZWrite"] = 1f
                }
            },
            thumbMaterial = new GSMaterialSettings
            {
                Colors = new Dictionary<string, Color>
                {
                    ["_AmbientColor"] = new(0.2274797f, 0.001245998f, 0.2641509f, 1f),
                    ["_Color"] = new(0.1098039f, 0.1336298f, 0.3215686f, 1f),
                    ["_ColorBio0"] = new(0.0283909f, 0.08649565f, 0.2075472f, 1f),
                    ["_ColorBio1"] = new(0.1192595f, 0.3773585f, 0.2648206f, 1f),
                    ["_ColorBio2"] = new(0.1953097f, 0.6558488f, 0.7264151f, 1f),
                    ["_EmissionColor"] = new(0f, 0f, 0f, 1f),
                    ["_FlowColor"] = new(0.7924528f, 0.7924528f, 0.7924528f, 0.7882353f),
                    ["_HeightSettings"] = new(-0.1f, 0.3f, 0.1f, 0.1f),
                    ["_HoloColor"] = new(0.3f, 0.7f, 0.25f, 0.2f),
                    ["_NotVisibleColor"] = new(0f, 0.03f, 0.07499998f, 0.2f),
                    ["_RimColor"] = new(0f, 0.555069f, 1f, 1f),
                    ["_Rotation"] = new(0.04780581f, -0.7943271f, 0.01065603f, -0.6055126f),
                    ["_ShoreLineColor"] = new(0.01214845f, 0.03161179f, 0.1226415f, 1f),
                    ["_SpecularColor"] = new(0.5188679f, 0.3004048f, 0.1737718f, 1f),
                    ["_Spot0"] = new(0.6f, -0.3f, -0.5f, 1f),
                    ["_SunDir"] = new(-0.06396604f, 0.01722677f, 0.9978034f, 0f)
                },
                Params = new Dictionary<string, float>
                {
                    ["_BioStrength"] = 1f,
                    ["_BodyIntensity"] = 0.27f,
                    ["_BumpScale"] = 1f,
                    ["_Cutoff"] = 0.5f,
                    ["_DetailNormalMapScale"] = 1f,
                    ["_Diameter"] = 0.1f,
                    ["_Distort"] = 0.01f,
                    ["_DstBlend"] = 0f,
                    ["_FarHeight"] = 0.5f,
                    ["_GlossMapScale"] = 1f,
                    ["_Glossiness"] = 0.15f,
                    ["_GlossyReflections"] = 1f,
                    ["_HoloIntensity"] = 0.8f,
                    ["_Metallic"] = 0.58f,
                    ["_Mode"] = 0f,
                    ["_Multiplier"] = 4f,
                    ["_NoiseIntensity"] = 0.15f,
                    ["_NoiseThres"] = 0f,
                    ["_OcclusionStrength"] = 1f,
                    ["_Parallax"] = 0.02f,
                    ["_PolarWhirl"] = -0.3f,
                    ["_PolarWhirlPower"] = 8f,
                    ["_ShoreHeight"] = 0f,
                    ["_ShoreInvThick"] = -10f,
                    ["_SmoothnessTextureChannel"] = 0f,
                    ["_SpecularHighlights"] = 1f,
                    ["_Speed"] = 2f,
                    ["_SrcBlend"] = 1f,
                    ["_Tile"] = 0.2f,
                    ["_TileX"] = 7f,
                    ["_TileY"] = 2.5f,
                    ["_TimeFactor"] = 0f,
                    ["_ToggleVerta"] = 0f,
                    ["_UVSec"] = 0f,
                    ["_WireIntens"] = 2f,
                    ["_ZWrite"] = 1f
                }
            }
        };
    }
}