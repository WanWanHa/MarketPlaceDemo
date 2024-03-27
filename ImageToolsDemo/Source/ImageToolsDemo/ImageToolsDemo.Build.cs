// Copyright WanWanHa NetWork Technology, LLC. All Rights Reserved.

using UnrealBuildTool;

public class ImageToolsDemo : ModuleRules
{
	public ImageToolsDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "ImageTools" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });
	}
}
