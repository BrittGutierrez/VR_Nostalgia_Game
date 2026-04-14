# VR_Nostalgia_Game

## What this is
This project is a VR nostalgia experience built in Unity. The idea is to recreate a childhood bedroom where you can interact with different objects and create a nostalgic, immersive space.

Right now we’re mainly focused on getting the core interactions working.

## What works so far
- TV you can interact with (has delay, static sound, and flicker effect)
- Sitting on the bed and bean bag (hover for a second and it snaps you into position)
- Picking up VCR's

## Videos
### Project Video
[https://youtu.be/m2i1una88eQ]

### Code Video
[https://youtu.be/xcYaRdA9RnQ]

## Paper
PDF is included in this repo.

Overleaf:  
[Checkpoint_1_CS465.pdf](https://github.com/user-attachments/files/26698804/Checkpoint_1_CS465.pdf)
https://www.overleaf.com/read/xcbwvtxyhvbt#15329f

## How it works (basic)
We used Unity with the XR Interaction Toolkit.

- The TV uses a script with a coroutine to handle the delay, flicker, and sound
- The bed and bean bag use a hover + timer system to move the player into a sitting position
- Pickup is mostly handled with XR Grab Interactable

We tried to keep everything simple so we can build on it later.

## Where we’re at right now
At this point we have a working environment with multiple interactions. The main goal so far was just getting everything functional and making it feel somewhat natural in VR.

## What we want to add next
Next we want to make the TV more interactive, like adding a VCR where you can actually put a VHS in and have it change what’s playing.

We also want to add more detail to the room so it feels more realistic, like decorations and smaller objects.

We’re thinking about adding a window interaction too, maybe where you can look outside or change the lighting depending on time of day.

Eventually we want to expand past just the bedroom and add more rooms in the house.

Overall we just want to make the space feel more interactive and immersive instead of static.

## Contributors
Brittany Gutierrez & 
Nathan Chapman
Colorado State University
<3
