// Copyright 2024 (c) WanWanHa NetWork Technology, LLC. All rights reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class Load3DFileDemoEditorTarget : TargetRules
{
	public Load3DFileDemoEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.Latest;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        ExtraModuleNames.AddRange( new string[] { "Load3DFileDemo" } );
	}
}
