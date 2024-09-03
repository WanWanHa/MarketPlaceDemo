// Copyright 2024 (c) WanWanHa NetWork Technology, LLC. All rights reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class RedisOperatorDemoTarget : TargetRules
{
	public RedisOperatorDemoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		ExtraModuleNames.Add("RedisOperatorDemo");
	}
}
