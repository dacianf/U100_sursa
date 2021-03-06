; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "U100"
#define MyAppVersion "1"
#define MyAppPublisher "Florea Dacian"
#define MyAppExeName "U100.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{A714D361-4C2D-4D1A-8E9E-079729A5F9FA}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={pf}\{#MyAppName}
DisableProgramGroupPage=yes
OutputDir=C:\Users\Daci\Desktop
OutputBaseFilename=U100_FloreaDacian_Setup
SetupIconFile=H:\proiecte C#\U100\U100\ro100.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "brazilianportuguese"; MessagesFile: "compiler:Languages\BrazilianPortuguese.isl"
Name: "catalan"; MessagesFile: "compiler:Languages\Catalan.isl"
Name: "corsican"; MessagesFile: "compiler:Languages\Corsican.isl"
Name: "czech"; MessagesFile: "compiler:Languages\Czech.isl"
Name: "danish"; MessagesFile: "compiler:Languages\Danish.isl"
Name: "dutch"; MessagesFile: "compiler:Languages\Dutch.isl"
Name: "finnish"; MessagesFile: "compiler:Languages\Finnish.isl"
Name: "french"; MessagesFile: "compiler:Languages\French.isl"
Name: "german"; MessagesFile: "compiler:Languages\German.isl"
Name: "greek"; MessagesFile: "compiler:Languages\Greek.isl"
Name: "hebrew"; MessagesFile: "compiler:Languages\Hebrew.isl"
Name: "hungarian"; MessagesFile: "compiler:Languages\Hungarian.isl"
Name: "italian"; MessagesFile: "compiler:Languages\Italian.isl"
Name: "japanese"; MessagesFile: "compiler:Languages\Japanese.isl"
Name: "norwegian"; MessagesFile: "compiler:Languages\Norwegian.isl"
Name: "polish"; MessagesFile: "compiler:Languages\Polish.isl"
Name: "portuguese"; MessagesFile: "compiler:Languages\Portuguese.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"
Name: "scottishgaelic"; MessagesFile: "compiler:Languages\ScottishGaelic.isl"
Name: "serbiancyrillic"; MessagesFile: "compiler:Languages\SerbianCyrillic.isl"
Name: "serbianlatin"; MessagesFile: "compiler:Languages\SerbianLatin.isl"
Name: "slovenian"; MessagesFile: "compiler:Languages\Slovenian.isl"
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"
Name: "turkish"; MessagesFile: "compiler:Languages\Turkish.isl"
Name: "ukrainian"; MessagesFile: "compiler:Languages\Ukrainian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "H:\proiecte C#\U100\U100\bin\Debug\U100.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "H:\proiecte C#\U100\U100\bin\Debug\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "F:\Download\netFrameWork_4.5.2.exe"; DestDir: "{app}\PreRequirements"; Flags: ignoreversion; BeforeInstall: installNetFramework
Source: "F:\Download\AccessDatabaseEngine.exe"; DestDir: "{app}\PreRequirements"; Flags: ignoreversion; AfterInstall: installAccess10_x86
Source: "F:\Download\AccessDatabaseEngine_X64.exe"; DestDir: "{app}\PreRequirements"; Flags: ignoreversion; AfterInstall: installAccess10_x64
Source: "F:\Download\AccessDatabaseEngine07.exe"; DestDir: "{app}\PreRequirements"; Flags: ignoreversion; AfterInstall: installAccess07

; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[Code]
procedure installNetFramework();
var
  RezultatInstalere: Integer;
begin
  MsgBox('Urmeaz� s� instal�m NetFramework 4.5.2.', mbInformation, MB_OK);
  if not RegKeyExists(HKEY_LOCAL_MACHINE, 'SOFTWARE\Microsoft\.NETFramework\policy\v4.0') then
    Exec(ExpandConstant('{app}\PreRequirements\netFrameWork_4.5.2.exe'),'','',SW_SHOWNORMAL, ewWaitUntilTerminated, RezultatInstalere);
end;
procedure installAccess07();
var
  RezultatInstalere: Integer;
begin
  MsgBox('Urmeaz� s� instal�m AccessDatabaseEngine07.exe.', mbInformation, MB_OK);
  Exec(ExpandConstant('{app}\PreRequirements\AccessDatabaseEngine07.exe'),'','',SW_SHOWNORMAL, ewWaitUntilTerminated, RezultatInstalere);
end;

procedure installAccess10_x86();
var
  RezultatInstalere: Integer;
begin
  MsgBox('Urmeaz� s� instal�m AccessDatabaseEngine.exe.', mbInformation, MB_OK);
  if not IsWin64 then
    Exec(ExpandConstant('{app}\PreRequirements\AccessDatabaseEngine.exe'),'','',SW_SHOWNORMAL, ewWaitUntilTerminated, RezultatInstalere);
end;

procedure installAccess10_x64();
var
  RezultatInstalere: Integer;
begin
  MsgBox('Urmeaz� s� instal�m AccessDatabaseEngine_X64.exe.', mbInformation, MB_OK);
  if IsWin64 then
    Exec(ExpandConstant('{app}\PreRequirements\AccessDatabaseEngine_X64.exe'),'','',SW_SHOWNORMAL, ewWaitUntilTerminated, RezultatInstalere);
end;
