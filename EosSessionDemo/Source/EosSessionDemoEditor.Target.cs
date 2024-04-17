// Copyright (c) 2024,  WanWanHa NetWork Technology, LLC. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class EosSessionDemoEditorTarget : TargetRules
{
	public EosSessionDemoEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V4;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		ExtraModuleNames.Add("EosSessionDemo");
	}
}
