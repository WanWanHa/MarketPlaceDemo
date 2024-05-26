// Copyright WanWanHa NetWork Technology, LLC. All Rights Reserved.

using UnrealBuildTool;

public class SerialCommunicationDemo : ModuleRules
{
	public SerialCommunicationDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "SerialCommunication" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });
	}
}
