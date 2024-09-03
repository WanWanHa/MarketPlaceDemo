// Copyright 2024 (c) WanWanHa NetWork Technology, LLC. All rights reserved.

using UnrealBuildTool;

public class RedisOperatorDemo : ModuleRules
{
	public RedisOperatorDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

	}
}
