// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class C_SC_RTD_MT_WSC : ModuleRules
{
	public C_SC_RTD_MT_WSC(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
