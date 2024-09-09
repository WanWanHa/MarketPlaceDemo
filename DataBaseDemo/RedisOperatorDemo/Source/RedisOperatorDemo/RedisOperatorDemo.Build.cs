// Copyright 2024 (c) WanWanHa NetWork Technology, LLC. All Rights Reserved.

using UnrealBuildTool;

public class RedisOperatorDemo : ModuleRules
{
	public RedisOperatorDemo(ReadOnlyTargetRules Target) : base(Target)
	{
        if (Target.Configuration != UnrealTargetConfiguration.Shipping)
        {
            OptimizeCode = CodeOptimization.Never;
        }

        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

	}
}
