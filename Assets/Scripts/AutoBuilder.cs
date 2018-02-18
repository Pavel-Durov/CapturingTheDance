using UnityEngine;
using UnityEditor;
using System.IO;
using System.Linq;
using System.Collections;

public static class AutoBuilder {
    
    [MenuItem("Build/iOS")]
    public static void iOSBuild ()
    {
        var scenes = EditorBuildSettings.scenes.Where(s => s.enabled).Select(s => s.path).ToArray();

        var outputFile = Application.dataPath + "/../XcodeProject";
        if(Directory.Exists(outputFile)){
            Directory.Delete(outputFile, true);
        }

        var target = BuildTarget.iOS;
        var options = BuildOptions.None;

        BuildPipeline.BuildPlayer(scenes, outputFile, target, options);
    }
		
	[MenuItem("Build/Android")]
	static void AndroidBuild()
	{
		var scenes = EditorBuildSettings.scenes.Where(s => s.enabled).Select(s => s.path).ToArray();

		var outputFile = Application.dataPath + "/../androidBuild.apk";
		if(File.Exists(outputFile)){
			File.Delete(outputFile);
		}

		var target = BuildTarget.Android;
		var options = BuildOptions.None;

		BuildPipeline.BuildPlayer(scenes, outputFile, target, options);
	}
}