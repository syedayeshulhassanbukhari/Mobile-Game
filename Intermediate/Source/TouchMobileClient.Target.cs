using UnrealBuildTool;

public class TouchMobileClientTarget : TargetRules
{
	public TouchMobileClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("TouchMobile");
	}
}
