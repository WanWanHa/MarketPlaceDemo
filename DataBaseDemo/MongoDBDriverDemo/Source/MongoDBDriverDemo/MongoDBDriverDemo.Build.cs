// Copyright 2024 (c) WanWanHa, LLC. All Rights Reserved.

using UnrealBuildTool;

public class MongoDBDriverDemo : ModuleRules
{
	public MongoDBDriverDemo(ReadOnlyTargetRules Target) : base(Target)
	{
        if (Target.Configuration != UnrealTargetConfiguration.Shipping)
        {
            OptimizeCode = CodeOptimization.Never;
        }

        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "Slate", "SlateCore" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });
	}
}
