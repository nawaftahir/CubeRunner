using UnityEditor;

public static class WebBuild
{
    [MenuItem("Tools/Build Web Version")]
    public static void Build()
    {
        // GitHub Pages can't send the headers compressed Unity builds need
        PlayerSettings.WebGL.compressionFormat = WebGLCompressionFormat.Disabled;

        BuildPipeline.BuildPlayer(new BuildPlayerOptions
        {
            scenes = new[] { "Assets/Scenes/Level01.unity", "Assets/Scenes/Level02.unity" },
            locationPathName = "docs",
            target = BuildTarget.WebGL,
        });
    }
}
