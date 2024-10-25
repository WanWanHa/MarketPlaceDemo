// // Copyright 2024 (c) WanWanHa, LLC. All Rights Reserved.

using UnrealBuildTool;

public class EosSessionDemo : ModuleRules
{
	public EosSessionDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "EnhancedInput", "OnlineSubsystemEOS" , "OnlineSubsystem" });


        PrivateDependencyModuleNames.AddRange(new string[]
        {
            "EosSession"
        });

    }
}
