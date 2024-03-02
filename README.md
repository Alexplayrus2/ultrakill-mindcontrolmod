# HOW TO USE
press m to cycle through enemies, if you want to stop playing as an enemy press n and restart the level
# KNOWN BUGS
other ranged enemies (e.g. maurice, stray, soldier) target your camera's position instead of your actual position
cycling through enemies is very buggy when theres more than one
you need to press m twice when controlling an enemy the first time after loading a level to actually control it
# showcase video
[![showcase](http://img.youtube.com/vi/t7V9F9F1pR0.jpg)](http://www.youtube.com/watch?v=t7V9F9F1pR0 "play as enemies - ultrakill mind control mod showcase and tutorial
")

# showcase video (OLD)
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
