// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class C_SC_RTD_MT_WSCEditorTarget : TargetRules
{
	public C_SC_RTD_MT_WSCEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("C_SC_RTD_MT_WSC");
	}
}
