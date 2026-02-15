using UnrealBuildTool;

public class TouchMobileEditorTarget : TargetRules
{
	public TouchMobileEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("TouchMobile");
	}
}
