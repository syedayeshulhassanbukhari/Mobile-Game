using UnrealBuildTool;

public class TouchMobileTarget : TargetRules
{
	public TouchMobileTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("TouchMobile");
	}
}
