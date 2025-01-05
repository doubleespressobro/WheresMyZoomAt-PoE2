using ExileCore2.Shared.Interfaces;
using ExileCore2.Shared.Nodes;
using ExileCore2.Shared.Attributes;

namespace WheresMyZoomAt;

public class WheresMyZoomAtSettings : ISettings
{
    public ToggleNode Enable { get; set; } = new ToggleNode(false);

    public ButtonNode EnableZoom { get; set; } = new ButtonNode();
    public ToggleNode EnableZoomAtLaunch { get; set; } = new ToggleNode(false);

    public ButtonNode EnableFastZoom { get; set; } = new ButtonNode();
    public ToggleNode EnableFastZoomAtLaunch { get; set; } = new ToggleNode(false);

    [Menu("Atlas Unzoom feature doesn't work right now.", "Please do not click this as it could create bugs.")]
    public ButtonNode EnableAtlasZoom { get; set; } = new ButtonNode();
    [Menu("Atlas Unzoom feature doesn't work right now.", "Please do not click this as it could create bugs.")]
    public ToggleNode EnableAtlasZoomAtLaunch { get; set; } = new ToggleNode(false);
    
    public ButtonNode EnableNoFog { get; set; } = new ButtonNode();
    public ToggleNode EnableNoFogAtLaunch { get; set; } = new ToggleNode(false);

    public ButtonNode EnableNoBlackBox { get; set; } = new ButtonNode();
    public ToggleNode EnableNoBlackBoxAtLaunch { get; set; } = new ToggleNode(false);

    public ButtonNode EnableBrightness { get; set; } = new ButtonNode();
    public ToggleNode EnableBrightnessAtLaunch { get; set; } = new ToggleNode(false);
}
