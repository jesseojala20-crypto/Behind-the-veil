// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class BehindTheVeil : ModuleRules
{
	public BehindTheVeil(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"BehindTheVeil",
			"BehindTheVeil/Variant_Horror",
			"BehindTheVeil/Variant_Horror/UI",
			"BehindTheVeil/Variant_Shooter",
			"BehindTheVeil/Variant_Shooter/AI",
			"BehindTheVeil/Variant_Shooter/UI",
			"BehindTheVeil/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
