// Copyright 2024 (c) WanWanHa, LLC. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class MongoDBDriverDemoEditorTarget : TargetRules
{
	public MongoDBDriverDemoEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;		
		ExtraModuleNames.AddRange( new string[] { "MongoDBDriverDemo" } );
	}
}
