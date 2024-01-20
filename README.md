# download the mod here - https://thunderstore.io/c/ultrakill/p/Alexplayrus1/Mind_Control/
# HOW TO USE
keep in mind this mod isnt perfect because its my first time making a bepinex mod

you will need bepinex configuration manager and unity explorer, close unity explorer on the intro screen with f7 so it doesnt crash, go to a level, enable cheats and enable invincibility, enemies attack eachother and enemies ignore player
once you did that spawn in an enemy, open unity explorer, open inspector and use mouse inspect (world), hover the mouse over the enemy you want to control, it will give you a path to the enemy
press esc and close unity explorer, press f1, press mindcontrol and paste or type the enemy path into the textbox, press close and now you should be kinda controlling the enemy

[![showcase](http://img.youtube.com/vi/dIYgIoY10IY/0.jpg)](http://www.youtube.com/watch?v=dIYgIoY10IY "ultrakill mind control mod showcase: play as enemies
")
# compile instructions
make sure you have dotnet installed for this, make a folder named lib inside of the folder where the source code is and copy these files into it (COPY PASTE THEM, DO NOT MOVE THEM OR YOUR GAME WILL BREAK): 
ULTRAKILL/BepInEx/core/BepInEx.dll
ULTRAKILL/BepInEx/core/0Harmony.dll
ULTRAKILL/ULTRAKILL_Data/Managed/UnityEngine.dll
ULTRAKILL/ULTRAKILL_Data/Managed/UnityEngine.CoreModule.dll
ULTRAKILL/ULTRAKILL_Data/Managed/Assembly-CSharp.dll
once you did all that, open a terminal, cd into the source code's folder and run ```batch
dotnet build```
