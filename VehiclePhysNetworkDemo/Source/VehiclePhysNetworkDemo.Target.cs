// Copyright 2024 (c) WanWanHa, LLC. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class VehiclePhysNetworkDemoTarget : TargetRules
{
	public VehiclePhysNetworkDemoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.Latest;

		ExtraModuleNames.AddRange( new string[] { "VehiclePhysNetworkDemo" } );
	}
}
