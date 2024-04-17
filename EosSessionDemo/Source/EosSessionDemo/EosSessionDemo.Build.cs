// Copyright (c) 2024,  WanWanHa NetWork Technology, LLC. All Rights Reserved.

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
