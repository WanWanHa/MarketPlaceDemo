// Copyright WanWanHa NetWork Technology, LLC. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class SteamSessionDemoTarget : TargetRules
{
	public SteamSessionDemoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_3;
		ExtraModuleNames.Add("SteamSessionDemo");
	}
}
