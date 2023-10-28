// Copyright (c) 2023, Hong Gu <guhong.usa@gmail.com>. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class WanWanHaGrpcDemoTarget : TargetRules
{
	public WanWanHaGrpcDemoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		ExtraModuleNames.Add("WanWanHaGrpcDemo");
	}
}
