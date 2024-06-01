// Copyright 2024 (c) WanWanHa NetWork Technology, LLC, All rights reserved.

using UnrealBuildTool;

public class SerialPortDemo : ModuleRules
{
	public SerialPortDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "SerialPort" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });
	}
}
