// Copyright (c) 2023, Hong Gu <guhong.usa@gmail.com>. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class WebSocketDemoTarget : TargetRules
{
	public WebSocketDemoTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_1;
		ExtraModuleNames.Add("WebSocketDemo");
	}
}
