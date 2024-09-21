// Copyright 2024 (c) WanWanHa NetWork Technology, LLC. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class MySqlOperatorDemoEditorTarget : TargetRules
{
	public MySqlOperatorDemoEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		ExtraModuleNames.AddRange(new string[] {"MySqlOperatorDemo"});
	}
}
