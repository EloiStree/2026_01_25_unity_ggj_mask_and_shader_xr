

```
git clone --recurse-submodules https://github.com/EloiStree/2026_01_25_unity_ggj_mask_and_shader_xr.git
```

===============


# Mask and Shader

> Practice Git, shaders, and the basics of Unity by participating in this project.



I was preparing a workshop for the coming year, 2026, when I read the theme **“Mask.”**

An idea came to mind: create a *Hello World* project where students learn what 3D is by creating a mask.
Then, create a shader effect linked to it and apply it to the Quest 3 camera or as a VR filter (for non-AR headsets).

The application makes masks from the community appear randomly in the field of view so the player can play with them.  
The player can grab the masks and see through them.  
An element of the game allows to know who created the mask.  
And a button allows to learn more on how he did it.   

## What to learn

* **Create a mask**
  * Create a 3D object
  * Create a mask and its texture
  * Create a Git package with dependencies
  * Make an asset that is loadable at runtime
  * Learn to respect conventions
    * Resources
    * Naming
    * Credit script
    * Texture-ready-to-use script
* Use Git to save a package
* Use Git Fork to add your package to the project


# R&D

* What would be the best way to see the shader in the mask when putting the mask.
* It is fun to see in between the eyes of the mask ?
* Do we apply a mask shape to the passthrough square given by the mask designer ?


## Upcoming dates where we could apply this workshop to test it

* **5 & 6 February:** Nid Dev 2 – End Mons
  One day to import a mask and create a Shader Graph effect
* **9 & 13 February:** What’s New in XR – Charleroi
  Step by step on how to create the game jam application and more
* **16–20 February:** Learn to Code by Playing – La Louvière
  *Do not apply*
* **23 & 24 February:** What Is XR – Tournai
  Create a mask in VR and import it into Unity with a basic Shader Graph
* **26 & 27 February:** What Is XR – Mons
  Create a mask in VR and import it into Unity with a basic Shader Graph
* **2 & 3 March:** What Is XR – Charleroi
  Create a mask in VR and import it into Unity with a basic Shader Graph
* **18 March:** Nid Dev 1 – Charleroi
  Create a mask and the Git package
* **25 March:** Nid Dev 2 – Charleroi
  Learn to use Shader Graph and read the texture with code
* **7 April:** Hello Git & XR Dev – Charleroi
  Learn Git by practicing the workshop
* **8 & 10 April:** Hello Git & XR Artist 😋 – Charleroi
  Learn Git by proposing a mask and a basic shader
* **18 April:** La Louvière Gaming
  Make kids test what was created by the previous students
* **11 May – 5 June:** XR Development with Godot – Charleroi
  Recreate the application code in Godot
* **11 & 12 June:** XR Gaming Initiation – Mons
  Recreate the application in Unity and improve it
* **(?) 28 September – 9 October:** What’s New in XR – Charleroi
  Recreate the game in SteamVR in VR

## To check

* Does **AssetBundle** still work?
* Are **Addressables** easy to use?
* Are **Compute Shaders** loadable at runtime?
  * From an AssetBundle
  * From a text file as HLSL
* Are **Shader Graphs** loadable at runtime?

## To do

* Create a Git repository to ease community management of the best masks to load in the project
  * As a manifest in Unity
  * As AssetBundles to load
* Make a copy of the package or a `git#commit` of the tools used on the last day of the jam.

