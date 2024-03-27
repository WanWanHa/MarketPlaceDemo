// Copyright WanWanHa NetWork Technology, LLC. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class FlyingAIDemoEditorTarget : TargetRules
{
	public FlyingAIDemoEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V4;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_3;
		ExtraModuleNames.Add("FlyingAIDemo");
	}
}
