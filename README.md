# CubesDemo

A simple VR demo project for educational purposes using the Oculus Integration package.

Scenes/CubesDemo.scene is the example scene, and there is an example script in the Scripts folder. Locomotion and
grabbing are enabled in the example scene, but you can disable the Locomotion scripts if you only need room-scale
movement. You will need the latest LTS version in the Unity 2019.4 series with Android build support. We recommend
Visual Studio as an IDE, since it has the best integration with Unity. The Editor might ask you to upgrade the project
version. All project members must use the same exact Unity version. You can develop faster by switching the platform
from Android to PC and running the project in Play mode through Oculus Link.

## Activating Developer Mode on Oculus Quest 2

Register as a developer at https://developer.oculus.com/sign-up/ and use the same account to set up your Quest headset. You may need to set up a payment method (the card will not be charged).
Turn on your Quest headset and open the Oculus app on the Android or iOS device you used to set up your Quest.

1. Tap Settings (bottom-right)
2. Select your connected Quest from the device list and connect to it
3. Tap More Settings which appears below your Quest in the device list
4. Tap Developer Mode
5. Tap the switch to enable developer mode
6. Exit Settings on the app & reboot your Quest using the right-side power button

After your Quest reboots, developer mode should be enabled. You can confirm this by checking for the Developer category
in the Quest's Settings menu.

## Installing Apps on Oculus Quest 2 via ADB

Android Debug Bridge (ADB) is included in the Android SDK and is the main tool used to communicate with an Android
device for debugging. ADB is a highly versatile tool and it’s recommended that you
read [official documentation](https://developer.android.com/studio/command-line/adb) .

For a list of available commands and options, make sure ADB is installed and enter:

```shell
adb help
```

### Connect to Headset with ADB

From the OS shell, it is possible to connect to and communicate with an Android device either directly through USB, or
via TCP/IP over a Wi-Fi connection.

To connect a device via USB, plug the device into the PC with a compatible USB cable. After connecting, open up an OS
shell and type:

```shell
adb devices
```

If the device is connected properly, ADB will show the device id list such as:

```shell
List of devices attached
    ce0551e7                device
```

ADB can’t be used if no device is detected. If your device is not listed, the most likely problem is that you did not
install the correct USB driver (
see [Oculus ADB Drivers](https://developer.oculus.com/downloads/package/oculus-adb-drivers/)). Trying another USB cable
and/or port can sometimes resolve connection issues.

### Use ADB to Install Applications

To install an APK on your mobile device using ADB, connect to the target device and verify connection using ADB devices
as described above. Then install the APK with the following command:

```shell
adb install <apk-path>
```

Use the -r option to overwrite an existing APK of the same name already installed on the target device. For example:

```shell
adb install -r C:\Dev\Android\MyProject\VrApp.apk
```

## Installing Apps on Oculus Quest 2 via SideQuest

Go to the [SideQuest download page](https://sidequestvr.com/download) and click the button to download SideQuest for
your operating system.

Open the downloaded file and run the installer. The installation process includes all the drivers needed for
transferring files to your Quest.

### Enable USB debugging
Next, we'll tell the Quest it's OK to connect to your computer:

1. Open the SideQuest app on your computer
2. Connect the Quest to your computer via USB cable.
3. Put on the Quest headset – you should see a window open asking you to Allow USB debugging.
4. Check the box labelled Always allow from this computer and click OK
Your Quest and computer are now set up for sideloading using the SideQuest app.

### To install any apk file:

1. Click the icon showing an arrow inside a box at the top of the Sidequest window.
2. Choose your apk from the window that opens

## Launching Custom Apps on Oculus Quest 2

1. From your Quest headset, go to Library -> Unknown Sources
2. Click the app you want to launch from the list on the right

## Recommended Unity Settings for Oculus Quest 2

To set the recommended settings for your Quest 2 Application, see the official recommended settings
from [Oculus website](https://developer.oculus.com/documentation/unity/unity-conf-settings/).

## Performance on Quest 2

When running standalone on the Quest 2, you should be using baked lightmaps as often as possible instead of realtime lighting. In addition to baked lighting, one shadow casting realtime directional light is often enough for objects that move at runtime. The example scene is set up in subtractive lighting mode for the best performance; in this mode, the "Static" checkbox may need to be toggled off for certain objects which need specular lighting, e.g. the metal tunnel in the demo scene.

If you run into performance issues, you can adjust the min and max render scale in the OVR Manager under OVRCameraRig. The default settings are quite high because the demo scene is very simple.

## Git

If you're not sure what to use, try https://tortoisegit.org/download/ on Windows. You can also use the CLI. The easiest way to get started is to fork this project on GitHub. For pushing your changes, you need to set up an access token (replaces the older password login which is now disabled on GitHub) or an SSH key (more advanced).

## Merging

Unity is able to intelligently merge some asset files in case of version conflicts. This is already configured in .gitattributes, but you need to add Unity's Tools directory to your PATH for Git to find the required smart merge tool (UnityYAMLMerge). The tools directory is usually something like "C:\Program Files\Unity\Hub\Editor\2019.4.34f1\Editor\Data\Tools". 

More information on setting the PATH environment variable on Windows: https://www.computerhope.com/issues/ch000549.htm

Generally, we don't recommend editing the same file concurrently. Avoid concurrent editing by making prefabs of the things you are working on, and only add them to the scene at the end once they are ready. Otherwise, you may run into merge conflicts and will have to solve them manually.

## Resources

https://polyhaven.com/
