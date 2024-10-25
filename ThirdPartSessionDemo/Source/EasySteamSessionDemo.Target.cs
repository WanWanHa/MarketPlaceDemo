// Copyright 2024 (c) WanWanHa, LLC. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class EasySteamSessionDemoTarget : TargetRules
{
	public EasySteamSessionDemoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_1;
		ExtraModuleNames.Add("EasySteamSessionDemo");
	}
}
