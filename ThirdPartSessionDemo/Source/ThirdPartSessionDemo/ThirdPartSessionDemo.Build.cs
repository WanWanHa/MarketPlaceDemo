// Copyright WanWanHa NetWork Technology, LLC. All Rights Reserved.

using UnrealBuildTool;

public class ThirdPartSessionDemo : ModuleRules
{
	public ThirdPartSessionDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "EnhancedInput" });


        PrivateDependencyModuleNames.AddRange(new string[]
        {
            "ThirdPartSession"
        });

    }
}
