// Copyright (c) 2023, Hong Gu <guhong.usa@gmail.com>. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class PrimitiveDrawDemoEditorTarget : TargetRules
{
	public PrimitiveDrawDemoEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "PrimitiveDrawDemo" } );
	}
}
