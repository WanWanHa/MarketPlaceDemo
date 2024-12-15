// Copyright 2024 (c) WanWanHa, LLC. All Rights Reserved.


using UnrealBuildTool;

public class SQLiteDriverDemo : ModuleRules
{
	public SQLiteDriverDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] { "SQLiteDriver" });

	}
}
