using ExileCore2.Shared.Interfaces;
using ExileCore2.Shared.Nodes;
using ExileCore2.Shared.Attributes;
using System.Runtime;

namespace WheresMyZoomAt;

public class WheresMyZoomAtSettings : ISettings
{
    public ToggleNode Enable { get; set; } = new ToggleNode(false);

    [Menu("Zoom Menu")]
    public ZoomMenu ZoomMenu { get; set; } = new ZoomMenu();

    [Menu("QOL Menu")]
    public QOLMenu QOLMenu { get; set; } = new QOLMenu();
}

[Submenu(CollapsedByDefault = false)]
public class ZoomMenu
{
    [Menu("Enable Unzoom", "Scroll Mouse Wheel to unzoom further.")]
    public ButtonNode EnableZoom { get; set; } = new ButtonNode();
    [Menu("Enable Unzoom at Launch", "Scroll Mouse Wheel to unzoom further.")]
    public ToggleNode EnableZoomAtLaunch { get; set; } = new ToggleNode(false);

    [Menu("Enable Fast Zoom", "Scroll Mouse Wheel unzoom faster.")]
    public ButtonNode EnableFastZoom { get; set; } = new ButtonNode();
    [Menu("Enable Fast Zoom at Launch", "Scroll Mouse Wheel unzoom faster.")]
    public ToggleNode EnableFastZoomAtLaunch { get; set; } = new ToggleNode(false);

    [Menu("Enable Atlas Unzoom", "Press the button and then drag the Atlas for it to unzoom.")]
    public ButtonNode EnableAtlasZoom { get; set; } = new ButtonNode();
    [Menu("Enable Atlas Unzoom at launch", "Press the button and then drag the Atlas for it to unzoom.")]
    public ToggleNode EnableAtlasZoomAtLaunch { get; set; } = new ToggleNode(false);
    [Menu("Keep Unzoom Always running", "Press the button and then drag the Atlas for it to unzoom.")]
    public ToggleNode KeepAtlasZoom { get; set; } = new ToggleNode(false);
    [Menu("Atlas Unzoom Value", "The Higher the value, the more zoomed in.")]
    public RangeNode<float> AtlasUnzoomValue { get; set; } = new RangeNode<float>(1.0f, 5f, 0.5f);
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
