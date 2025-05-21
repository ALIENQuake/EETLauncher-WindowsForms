# EETLauncher - Windows Forms

**EETLauncher** is a launcher for EET with minimal configuration options.

## Features

- Support for EEEx  
- Open the EET readme file  
- Open the EET forum  
- Open the EET website  
- Open the appropriate `baldur.lua` for EET  
- Ability to switch between EET GUIs  

## Technology Stack

- **c#**  
- **Windows Forms**  

## SAPIEN Notes

- **File Management:**  
  Each project file (`.pss`, `.ps1`, `.psf`) has a `Properties > Build Order` setting. Pay attention to this when creating new files.

- **Entry Point:**  
  The application starts from `Startup.pss`. Function implementations are located in the `Functions.ps1` file.

- **Shared Properties:**  
  The `Functions.ps1` file is set to `Shared=True`, making all defined variables, functions, and classes globally available—except within runspaces.

- **Job Tracker:**  
  SAPIEN provides a built-in "Background Process" template. Unfortunately, it can cause the GUI to lag when modifying control properties. Use runspaces instead.

## Key Remarks

- **Simple Windows Forms implementation:**  
  Nothing complicated, it should be easy to start with.
