# OW Overlay

A simple overlay for streaming to track win/lose and sr in overwatch.
OW Overlay is an overlay for OBS (or variants) that displays the skill rating and win-loss-draw record for live Overwatch™ streams. Overlay is purely cosmetic and does not collect or report any data of the user. You can use it while streaming or recording. Display values are manually updated via the controller panel, or by updating the `score.json` file.

<p align="center">
  <img src="https://github.com/hbostann/OWOverlay/blob/master/help/demo.gif" alt="DEMO">
</p>

## Installation

1. Download the latest [release](https://github.com/hbostann/OWOverlay/releases) and extract the archive to a local folder.

2. Go into the fonts folder, select both fonts, right click and select **Install**.

#### OBS Configuration

Before using OW Overlay, you must configure your choice of OBS. Following instructions are valid for *OBS Studio* and *SLOBS*. Steps you need to follow should be same for other OBS variants, however screens may look quite different.

1. Create a browser source in your scene by clicking the `+` button for Sources pane and selecting **Browser**.
<p align="center">
  <img src="https://github.com/hbostann/OWOverlay/blob/master/help/scene.png?raw=true" alt="Scene Creation"/>
  <img src="https://github.com/hbostann/OWOverlay/blob/master/help/browser.png?raw=true" alt="Browser creation">
</p>

2. In the next dialog, select **Create new** and give it a name you can easily identify and click **OK**.

3. Modify the source properties as follows and click **OK**:

   - Check **Local file** checkbox
   - Click on browse and point to location of `overlay.html` you extracted.
   - Set width and height values as you wish. *However*, too small values may cause wrapping and overflows
   - Set **FPS** to 60 for smooth animation
   - Make sure **Custom CSS** field is *empty*.
   - Check **Refresh browser when scene becomes active**

<p align="center">
  <img src="https://github.com/hbostann/OWOverlay/blob/master/help/props.png?raw=true" alt="Properties">
</p>

Overlay should now be visible and working.

#### Usage

After OBS configuration, run `OWOverlayController.exe`. This will bring up the controller. Make sure that the `OWOverlayController.exe`, `overlay.html` and `score.json` file are in the same location.

<p align="center">
  <img src="https://github.com/hbostann/OWOverlay/blob/master/help/Controller.png?raw=true" alt="Controller">
</p>

You can update the values shown in the controller by directly typing into the field or by using the buttons. When a field is updated the overlay should automatically update itself.

## FAQ and Troubleshooting

> Fonts in controller doesn't look right?

Make sure that you install the fonts in the fonts folder.

> How do I reset the values?

Open the `score.json` file and put in the values you want for each field. Make sure that the controller is not running while doing this.

## License

[GNU GPLv3](https://choosealicense.com/licenses/gpl-3.0/)
