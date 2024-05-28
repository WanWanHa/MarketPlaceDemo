// Copyright WanWanHa NetWork Technology, LLC. All Rights Reserved.

using UnrealBuildTool;

public class SerialPortDemo : ModuleRules
{
	public SerialPortDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "SerialCommunication" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });
	}
}
