using ExileCore2.Shared.Interfaces;
using ExileCore2.Shared.Nodes;

namespace WheresMyZoomAt;

public class WheresMyZoomAtSettings : ISettings
{
    public ToggleNode Enable { get; set; } = new ToggleNode(false);

    public ButtonNode EnableZoom { get; set; } = new ButtonNode();
    public ToggleNode EnableZoomAtLaunch { get; set; } = new ToggleNode(false);
    public ButtonNode EnableFastZoom { get; set; } = new ButtonNode();
    public ToggleNode EnableFastZoomAtLaunch { get; set; } = new ToggleNode(false);
    public ButtonNode EnableNoFog { get; set; } = new ButtonNode();
    public ToggleNode EnableNoFogAtLaunch { get; set; } = new ToggleNode(false);
    public ButtonNode EnableNoBlackBox { get; set; } = new ButtonNode();
    public ToggleNode EnableNoBlackBoxAtLaunch { get; set; } = new ToggleNode(false);
    public ButtonNode EnableBrightness { get; set; } = new ButtonNode();
    public ToggleNode EnableBrightnessAtLaunch { get; set; } = new ToggleNode(false);
}
