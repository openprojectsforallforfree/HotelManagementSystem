; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{E93C0F1A-E0A9-41B2-AC32-F2F93EC995AB}
AppName=NgoPro
AppVerName=NgoPro
DefaultDirName={pf}\NgoPro
DefaultGroupName=NgoPro
OutputDir=C:\Dhiraj\WorkingFolder\BigSource\SetupOutput
OutputBaseFilename=setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: english; MessagesFile: compiler:Default.isl

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked

[Files]
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\NGOPro.exe; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\NGOPro.exe.config; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\Commands.txt; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\CrudeFx.NepaliDate.dll; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\digitalcontrol.dll; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\fsButton.dll; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\ibex35.dll; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\Microsoft.Office.Interop.Excel.dll; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\Microsoft.Vbe.Interop.dll; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\office.dll; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\PopupCalculator.dll; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\SQLite.Interop.dll; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\Syscom1.dll; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\Syscom2.dll; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\Syscom3.dll; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\Syscom4.dll; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\Syscom5.dll; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\Syscom6.dll; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\Syscom7.dll; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\Syscom8.dll; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\Syscom9.dll; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\Syscom10.dll; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\Syscom11.dll; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\System.Data.SQLite.dll; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\System.Data.SQLite.Linq.dll; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\northwindEF.db; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\Bsoft.exe; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\Syscom10.vshost.exe; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\Syscom12.exe; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\test.exe; DestDir: {app}; Flags: ignoreversion
Source: C:\Dhiraj\WorkingFolder\BigSource\Build\testlinq.exe; DestDir: {app}; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: {group}\NgoPro; Filename: {app}\NGOPro.exe
Name: {commondesktop}\NgoPro; Filename: {app}\NGOPro.exe; Tasks: desktopicon

[Run]
Filename: {app}\NGOPro.exe; Description: {cm:LaunchProgram,NgoPro}; Flags: nowait postinstall skipifsilent

