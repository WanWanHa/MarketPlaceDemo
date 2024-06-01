// Copyright 2024 (c) WanWanHa NetWork Technology, LLC. All rights reserved.

using UnrealBuildTool;

public class Load3DFileDemo : ModuleRules
{
	public Load3DFileDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] { "Load3DFile" });
	}
}
