; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{17274986-49FA-4C55-845A-3256F24885EF}}
AppName=Ticketing System
AppVerName=Ticketing System V2
AppPublisher=Picasso Consultant
DefaultDirName=D:\Software\Ticketing System
DefaultGroupName=TicketingSystem
InfoBeforeFile=..\WriteUps\PasalSystem.txt
OutputDir=..\SetupOutput
OutputBaseFilename=Ticketing System Setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: english; MessagesFile: compiler:Default.isl

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked

[Files]
Source: "..\Build\Restosys.exe"; DestDir: "{app}"; DestName: "TicketSys.exe"; Flags: ignoreversion
Source: "..\Build\Bsoft.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Build\Syscom12.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Build\testlinq.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Build\CrudeFx.NepaliDate.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Build\digitalcontrol.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Build\fsButton.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Build\ibex35.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Build\Microsoft.Office.Interop.Excel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Build\Microsoft.Vbe.Interop.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Build\office.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Build\PopupCalculator.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Build\SQLite.Interop.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Build\Syscom1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Build\Syscom2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Build\Syscom3.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Build\Syscom4.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Build\Syscom5.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Build\Syscom6.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Build\Syscom7.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Build\Syscom8.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Build\Syscom9.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Build\Syscom10.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Build\Syscom11.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Build\System.Data.SQLite.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Build\System.Data.SQLite.Linq.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Build\Commands.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Configs\TicketingSys.exe.config"; DestDir: "{app}"; DestName: "Restosys.exe.config"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: {group}\TicketingSystem; Filename: {app}\TicketSys.exe; WorkingDir: {app}; IconIndex: 0
Name: {commondesktop}\TicketingSystem; Filename: {app}\TicketSys.exe; Tasks: desktopicon; WorkingDir: {app}; IconIndex: 0

[Run]
Filename: {app}\TicketSys.exe; Description: {cm:LaunchProgram,Ticketing System}; Flags: nowait postinstall skipifsilent

