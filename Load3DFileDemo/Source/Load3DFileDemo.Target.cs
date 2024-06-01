// Copyright 2024 (c) WanWanHa NetWork Technology, LLC. All rights reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class Load3DFileDemoTarget : TargetRules
{
	public Load3DFileDemoTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
        DefaultBuildSettings = BuildSettingsVersion.Latest;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        ExtraModuleNames.AddRange( new string[] { "Load3DFileDemo" } );
	}
}
