// Copyright WanWanHa NetWork Technology, LLC. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class SerialPortDemoTarget : TargetRules
{
	public SerialPortDemoTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
        DefaultBuildSettings = BuildSettingsVersion.Latest;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        ExtraModuleNames.AddRange( new string[] { "SerialPortDemo" } );
	}
}
