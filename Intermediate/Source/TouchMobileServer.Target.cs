using UnrealBuildTool;

public class TouchMobileServerTarget : TargetRules
{
	public TouchMobileServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("TouchMobile");
	}
}
