﻿using System;
using MelonLoader;
using ModioModNetworker; // The namespace of your mod class
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using LabFusion.SDK.Modules;

// ...
[assembly: MelonInfo(typeof(MainClass), "ModioModNetworker", ModioModNetworkerUpdaterVersion.versionString, "notnotnotswipez")]
[assembly: ModuleInfo(typeof(ModlistModule), "ModioModNetworkerModule", ModioModNetworkerUpdaterVersion.versionString, "notnotnotswipez", "modiomodule", true, ConsoleColor.DarkCyan)]

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("ModioModNetworker")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("ModioModNetworker")]
[assembly: AssemblyCopyright("Copyright ©  2023")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("cdde6516-f286-4f2c-ad4b-d75164eb3e75")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion(ModioModNetworkerUpdaterVersion.versionString)]
[assembly: AssemblyFileVersion(ModioModNetworkerUpdaterVersion.versionString)]
