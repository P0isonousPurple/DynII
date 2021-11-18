![DynII Banner](https://otto-spaude.me/gh-media/dynii_banner_02.png)
Dynamic Input Icons (DynII) is a Unity Package that switches input prompts automatically for you based on the current control scheme.


## How to use
1. Import DynII as Unity Package into your project (creating a seperate folder in the Assets folder is recommended!)
2. If you didnt already, install the new Input System from Unity and set it up with three device schemes (XBox, PC and PS4) If you don't know how to set up / install the Input System, see [the docs](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.0/manual/Installation.html)
3. Create a empty GameObject, name it "Icon Manager" and add the **IconManager** script to it.
4. Reference in the "Keyboard Mouse Scheme", the "Ps 4 Scheme" and the "XboxScheme" your control schemes from your Input Action Asset (It's case sensitive!)
5. Add the amount of switches that you need (one switch can be used for multiple sprites or UI images) For example:

   ![Example Switch](https://otto-spaude.me/gh-media/dynii_01.png)
   
   The **Name** changes nothing but can help you with orientation when you use a lot of switches. In the example, the switch has the same name as the keys it uses.
   
   In the **Device Icons** array, the different icons for the different devices are getting defined. **Important: You always have to reference the icons in this order (PC Icon, PS4 Icon, XBox Icon)**
   
   In the **Sprites to Switch** Array, you can reference the sprite GameObjects in wich you want to display the input propmts.
   
   In the **UI Images to Switch** Array, you can reference the UI Images in wich you want to display the input propmts.
6. Add a **Player Input** component to your GameObject of choice.
7. Reference you Input Actions Asset in the **Actions** field and enable **Auto-Switch** if you didn't already.
8. Change the in the **Player Input** the **Behaviour** field to **Invoke Unity Events**, open the the **Events** dropdown, add a entry to to the **Controls Changed Event (PlayerInput)** List and reference the **Icon Manager** GameObject in it. After that, select in the **No Function** dropdown **Icon Manager > OnDeviceChange()**
9. Done! If you have any questions or bugs, feel free to open a issue :) I Will reply as fast as I can.



Feel free to also test around in the **DynII Example Scene** that you can find in the **Example Scenes** folder.

Icons by Nicolae (XELU) Berbece. [Download Here](https://thoseawesomeguys.com/prompts/)
