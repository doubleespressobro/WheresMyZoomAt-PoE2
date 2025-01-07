using ExileCore2.Shared.Interfaces;
using ExileCore2.Shared.Nodes;
using ExileCore2.Shared.Attributes;

namespace WheresMyZoomAt;

public class WheresMyZoomAtSettings : ISettings
{
    public ToggleNode Enable { get; set; } = new ToggleNode(false);

    [Menu("Zoom")]
    public ZoomMenu ZoomMenu { get; set; } = new ZoomMenu();

    [Menu("Misc")]
    public QOLMenu QOLMenu { get; set; } = new QOLMenu();
}

[Submenu(CollapsedByDefault = false)]
public class ZoomMenu
{
    [Menu("Enable Zoom", "Allows you to zoom the game out further than usual.")]
    public ButtonNode EnableZoom { get; set; } = new ButtonNode();
    [Menu("Enable Unzoom on startup", "Automatically enable Zoom on startup.")]
    public ToggleNode EnableZoomAtLaunch { get; set; } = new ToggleNode(false);

    [Menu("Enable Fast Zoom", "Zooms in/out faster with scroll wheel.")]
    public ButtonNode EnableFastZoom { get; set; } = new ButtonNode();
    [Menu("Enable Fast Zoom on startup", "Automatically enable Fast Zoom on startup.")]
    public ToggleNode EnableFastZoomAtLaunch { get; set; } = new ToggleNode(false);

    [Menu("Enable Atlas Zoom", "Allows the atlas to be zoomed out further than usual.")]
    public ButtonNode EnableAtlasZoom { get; set; } = new ButtonNode();
    [Menu("Enable Atlas Zoom on startup", "Automatically enable Atlas Zoom on startup. (Click+Drag the atlas so the value updates)")]
    public ToggleNode EnableAtlasZoomAtLaunch { get; set; } = new ToggleNode(false);
    [Menu("Persistant Zoom Value", "Ensures the zoom value is rewritten if it ever gets overwritten. (Click+Drag the atlas so the value updates)")]
    public ToggleNode KeepAtlasZoom { get; set; } = new ToggleNode(false);
    [Menu("Atlas Unzoom Value", "The Higher the value, the more zoomed in.")]
    public RangeNode<float> AtlasZoomValue { get; set; } = new RangeNode<float>(1.0f, 5f, 0.5f);
}

[Submenu(CollapsedByDefault = false)]
public class QOLMenu
{
    public ButtonNode EnableNoFog { get; set; } = new ButtonNode();
    public ToggleNode EnableNoFogAtLaunch { get; set; } = new ToggleNode(false);

    public ButtonNode EnableNoBlackBox { get; set; } = new ButtonNode();
    public ToggleNode EnableNoBlackBoxAtLaunch { get; set; } = new ToggleNode(false);

    public ButtonNode EnableBrightness { get; set; } = new ButtonNode();
    public ToggleNode EnableBrightnessAtLaunch { get; set; } = new ToggleNode(false);
}
