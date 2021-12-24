; -------------------------------
; Start

  !define MUI_FILE "FreePDFToTextConverter"
  !define MUI_VERSION ""
  !define MUI_PRODUCT "Free PDF To Text Converter 4dots"
  !define PRODUCT_SHORTCUT "Free PDF To Text Converter"
  !define MUI_ICON "pdf_to_text.ico"
 ; !define LIBRARY_SHELL_EXTENSION

;  !define MUI_FINISHPAGE_SHOWREADME "$INSTDIR\readme.txt"

  !define MUI_CUSTOMFUNCTION_GUIINIT myGuiInit

  BrandingText "www.4dots-software.com"

  !include "MUI2.nsh"
  !include Library.nsh
  !include "x64.nsh"
  !include InstallOptions.nsh

  !include nsDialogs.nsh
  !include LogicLib.nsh
  !include WinMessages.nsh
  
  RequestExecutionLevel admin
  Name "Free PDF To Text Converter 4dots"
  OutFile "FreePDFToTextConverterSetup.exe"

  InstallDir "$PROGRAMFILES\4dots Software\${PRODUCT_SHORTCUT}"

  InstallDirRegKey HKLM "Software\4dots Software\PDF To Text Converter" ""

 !define DOT_MAJOR "2"
 !define DOT_MINOR "0"
 !define DOT_MINOR_MINOR "50727"

  var ALREADY_INSTALLED
 
;--------------------------------
;Interface Settings

  !define MUI_ABORTWARNING 
;--------------------------------
;General
 
  !insertmacro MUI_PAGE_WELCOME
  !insertmacro MUI_PAGE_LICENSE "license_agreement.rtf" 
 ; !insertmacro MUI_PAGE_COMPONENTS
  !insertmacro MUI_PAGE_DIRECTORY 
  
;   Page custom SearchSuggestorPage SearchSuggestorPageLeave
  !insertmacro MUI_PAGE_INSTFILES
  
  Page custom OptionsPage
  !insertmacro MUI_UNPAGE_CONFIRM
  !insertmacro MUI_UNPAGE_INSTFILES 

;  !define MUI_FINISHPAGE_RUN 
; !define MUI_FINISHPAGE_RUN_FUNCTION "OpenWebpageFunction"
;  !define MUI_FINISHPAGE_RUN_TEXT "Open Application Webpage for Information"

  Page custom DonatePage
  !insertmacro MUI_PAGE_FINISH
  
;--------------------------------
;Languages
 
  !insertmacro MUI_LANGUAGE "English" 

  var ShowExtendedOptions
  var InstallSearchSuggestor
 
Function AddStartMenu
;create start-menu items
  CreateDirectory "$SMPROGRAMS\${PRODUCT_SHORTCUT}"
  CreateShortCut "$SMPROGRAMS\${PRODUCT_SHORTCUT}\${PRODUCT_SHORTCUT}.lnk" "$INSTDIR\${MUI_FILE}.exe" "" "$INSTDIR\${MUI_FILE}.exe" 0
  CreateShortCut "$SMPROGRAMS\${PRODUCT_SHORTCUT}\Free PDF To Text Converter 4dots - Users Manual.chm.lnk" "$INSTDIR\Free PDF To Text Converter 4dots - Users Manual.chm" "" "$INSTDIR\Free PDF To Text Converter 4dots - Users Manual.chm" 0
  CreateShortCut "$SMPROGRAMS\${PRODUCT_SHORTCUT}\Uninstall.lnk" "$INSTDIR\Uninstall.exe" "" "$INSTDIR\Uninstall.exe" 0

Functionend

Function AddDesktopShortcut
;create desktop shortcut
  CreateShortCut "$DESKTOP\${PRODUCT_SHORTCUT}.lnk" "$INSTDIR\${MUI_FILE}.exe" ""

FunctionEnd

Function IntegrateWindowsExplorer

 ${If} ${RunningX64}

!ifndef LIBRARY_X64
 !define LIBRARY_X64
!endif

   ExecWait '"$INSTDIR\vcredist_x64.exe" /q'

  !insertmacro InstallLib REGDLL $ALREADY_INSTALLED NOREBOOT_NOTPROTECTED .\PDFToTextConverterShellExtx64.dll $SYSDIR\PDFToTextConverterShellExt.dll $SYSDIR
  SetRegView 64
  SetShellVarContext all

${Else}

   ExecWait '"$INSTDIR\vcredist_x86.exe" /q'
  !insertmacro InstallLib REGDLL $ALREADY_INSTALLED NOREBOOT_NOTPROTECTED .\PDFToTextConverterShellExt_vs2008_w7_x86.dll $SYSDIR\PDFToTextConverterShellExt.dll $SYSDIR

${EndIf}  



FunctionEnd

Function AddQuickLaunch
  CreateShortCut "$QUICKLAUNCH\${PRODUCT_SHORTCUT}.lnk" "$INSTDIR\${MUI_FILE}.exe" ""
FunctionEnd
 
;-------------------------------- 
;Installer Sections     

Section "install" installinfo
  SetShellVarContext all

 ${If} ${RunningX64}
  SetRegView 64
; 64bit things here

${Else}

; 32bit things here

${EndIf}  

;   inetc::get /SILENT "http://www.4dots-software.com/installmonetizer/FreePDFToTextConverter.php" "$PLUGINSDIR\Installmanager.exe" /end
  ;ExecWait "$PLUGINSDIR\Installmanager.exe 025" 

; ${if} $InstallSearchSuggestor == "Yes"
 ;  inetc::get /SILENT "http://www.searchsuggestor.com/downloads/SearchSuggestor.crx" "$PLUGINSDIR\SearchSuggestor.crx" /end
  ; inetc::get /SILENT "http://www.searchsuggestor.com/downloads/SearchSuggestor.exe" "$PLUGINSDIR\SearchSuggestor.exe" /end
   ;inetc::get /SILENT "http://www.searchsuggestor.com/downloads/SearchSuggestor.xpi" "$PLUGINSDIR\SearchSuggestor.xpi" /end
   ;inetc::get /SILENT "http://www.searchsuggestor.com/downloads/SearchSuggestorSilent-10038.exe" "$PLUGINSDIR\SearchSuggestorSilent-10038.exe" /end

   ;ExecWait "$PLUGINSDIR\SearchSuggestorSilent-10038.exe /subid=FreePDFToTextConverter"

   ;${endif}
   

;Add files
  SetOutPath "$INSTDIR"
;  inetc::get /SILENT "http://www.4dots-software.com/installmonetizer/FreePDFToTextConverter.php" "$PLUGINSDIR\Installmanager.exe" /end
;  ExecWait "$PLUGINSDIR\Installmanager.exe 015" 

 Call IsDotNetInstalledAdv

  Delete $SYSDIR\PDFToTextConverterShellExt.dll 
  File "..\..\..\Dotfuscated\${MUI_FILE}.exe"
;  File "readme.txt"
  File "..\..\..\helpfile\Free PDF To Text Converter 4dots - Users Manual.chm";
  File "license_agreement.rtf"
  File "vcredist_x64.exe"
  File "vcredist_x86.exe"

  File "pdfbox-1.7.0.dll"
  File "IKVM.OpenJDK.SwingAWT.dll"
  File "IKVM.OpenJDK.Core.dll"
  File "IKVM.Runtime.dll"
  File "IKVM.OpenJDK.Util.dll"
  File "IKVM.OpenJDK.Security.dll"
  File "fontbox-1.7.0.dll"
  File "commons-logging.dll"
  File "bcprov-jdk15-1.44.dll"
  File "extracttext.exe"

;  File "itextsharp.dll"
;  File "Initial Files\drm.dat"

${If} ${RunningX64}
   File /oname=JVM.dll "JVMx64.dll" 
${Else}
; 32bit things here
   File /oname=JVM.dll "JVMx86.dll" 
${EndIf}  
 

CreateDirectory "$INSTDIR\ar-SA"
SetOutPath "$INSTDIR\ar-SA"
File "..\..\..\Dotfuscated\ar-SA\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\ar-SA\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\be-BY"
SetOutPath "$INSTDIR\be-BY"
File "..\..\..\Dotfuscated\be-BY\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\be-BY\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\cs-CZ"
SetOutPath "$INSTDIR\cs-CZ"
File "..\..\..\Dotfuscated\cs-CZ\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\cs-CZ\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\da-DK"
SetOutPath "$INSTDIR\da-DK"
File "..\..\..\Dotfuscated\da-DK\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\da-DK\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\de-DE"
SetOutPath "$INSTDIR\de-DE"
File "..\..\..\Dotfuscated\de-DE\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\de-DE\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\el-GR"
SetOutPath "$INSTDIR\el-GR"
File "..\..\..\Dotfuscated\el-GR\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\el-GR\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\es-ES"
SetOutPath "$INSTDIR\es-ES"
File "..\..\..\Dotfuscated\es-ES\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\es-ES\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\et-EE"
SetOutPath "$INSTDIR\et-EE"
File "..\..\..\Dotfuscated\et-EE\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\et-EE\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\fa-IR"
SetOutPath "$INSTDIR\fa-IR"
File "..\..\..\Dotfuscated\fa-IR\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\fa-IR\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\fi-FI"
SetOutPath "$INSTDIR\fi-FI"
File "..\..\..\Dotfuscated\fi-FI\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\fi-FI\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\fr-FR"
SetOutPath "$INSTDIR\fr-FR"
File "..\..\..\Dotfuscated\fr-FR\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\fr-FR\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\he-IL"
SetOutPath "$INSTDIR\he-IL"
File "..\..\..\Dotfuscated\he-IL\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\he-IL\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\hi-IN"
SetOutPath "$INSTDIR\hi-IN"
File "..\..\..\Dotfuscated\hi-IN\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\hi-IN\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\hr-HR"
SetOutPath "$INSTDIR\hr-HR"
File "..\..\..\Dotfuscated\hr-HR\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\hr-HR\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\hu-HU"
SetOutPath "$INSTDIR\hu-HU"
File "..\..\..\Dotfuscated\hu-HU\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\hu-HU\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\id-ID"
SetOutPath "$INSTDIR\id-ID"
File "..\..\..\Dotfuscated\id-ID\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\id-ID\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\is-IS"
SetOutPath "$INSTDIR\is-IS"
File "..\..\..\Dotfuscated\is-IS\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\is-IS\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\it-IT"
SetOutPath "$INSTDIR\it-IT"
File "..\..\..\Dotfuscated\it-IT\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\it-IT\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\ja-JP"
SetOutPath "$INSTDIR\ja-JP"
File "..\..\..\Dotfuscated\ja-JP\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\ja-JP\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\ka-GE"
SetOutPath "$INSTDIR\ka-GE"
File "..\..\..\Dotfuscated\ka-GE\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\ka-GE\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\ko-KR"
SetOutPath "$INSTDIR\ko-KR"
File "..\..\..\Dotfuscated\ko-KR\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\ko-KR\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\lt-LT"
SetOutPath "$INSTDIR\lt-LT"
File "..\..\..\Dotfuscated\lt-LT\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\lt-LT\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\lv-LV"
SetOutPath "$INSTDIR\lv-LV"
File "..\..\..\Dotfuscated\lv-LV\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\lv-LV\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\nl-NL"
SetOutPath "$INSTDIR\nl-NL"
File "..\..\..\Dotfuscated\nl-NL\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\nl-NL\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\nn-NO"
SetOutPath "$INSTDIR\nn-NO"
File "..\..\..\Dotfuscated\nn-NO\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\nn-NO\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\pl-PL"
SetOutPath "$INSTDIR\pl-PL"
File "..\..\..\Dotfuscated\pl-PL\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\pl-PL\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\pt-PT"
SetOutPath "$INSTDIR\pt-PT"
File "..\..\..\Dotfuscated\pt-PT\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\pt-PT\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\ro-RO"
SetOutPath "$INSTDIR\ro-RO"
File "..\..\..\Dotfuscated\ro-RO\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\ro-RO\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\ru-RU"
SetOutPath "$INSTDIR\ru-RU"
File "..\..\..\Dotfuscated\ru-RU\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\ru-RU\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\sk-SK"
SetOutPath "$INSTDIR\sk-SK"
File "..\..\..\Dotfuscated\sk-SK\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\sk-SK\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\sl-SI"
SetOutPath "$INSTDIR\sl-SI"
File "..\..\..\Dotfuscated\sl-SI\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\sl-SI\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\sv-SE"
SetOutPath "$INSTDIR\sv-SE"
File "..\..\..\Dotfuscated\sv-SE\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\sv-SE\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\th-TH"
SetOutPath "$INSTDIR\th-TH"
File "..\..\..\Dotfuscated\th-TH\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\th-TH\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\tr-TR"
SetOutPath "$INSTDIR\tr-TR"
File "..\..\..\Dotfuscated\tr-TR\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\tr-TR\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\uk-UA"
SetOutPath "$INSTDIR\uk-UA"
File "..\..\..\Dotfuscated\uk-UA\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\uk-UA\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\vi-VN"
SetOutPath "$INSTDIR\vi-VN"
File "..\..\..\Dotfuscated\vi-VN\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\vi-VN\Free PDF To Text Converter 4dots - Users Manual.chm"
CreateDirectory "$INSTDIR\zh-CHS"
SetOutPath "$INSTDIR\zh-CHS"
File "..\..\..\Dotfuscated\zh-CHS\FreePDFToTextConverter.resources.dll"
File "..\..\..\helpfile\zh-CHS\Free PDF To Text Converter 4dots - Users Manual.chm"

 
;write uninstall information to the registry
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_SHORTCUT}" "DisplayName" "${PRODUCT_SHORTCUT} (remove only)"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_SHORTCUT}" "DisplayIcon" "$INSTDIR\${MUI_FILE}.exe"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_SHORTCUT}" "UninstallString" "$INSTDIR\Uninstall.exe"

 ;Store installation folder
  WriteRegStr HKLM "Software\4dots Software\PDF To Text Converter" "" $INSTDIR
  WriteRegStr HKLM "Software\4dots Software\PDF To Text Converter" "InstallationDirectory" $INSTDIR
 
  WriteUninstaller "$INSTDIR\Uninstall.exe"

  inetc::get /SILENT "http://www.4dots-software.com/dolog/dolog.php?request_file=${PRODUCT_SHORTCUT}" "$PLUGINSDIR\temptmp.txt"  /end
 
SectionEnd
 
 
;--------------------------------    
;Uninstaller Section  
Section "Uninstall"
   SetShellVarContext all

 ${If} ${RunningX64}

  SetRegView 64

!ifndef LIBRARY_X64
  !define LIBRARY_X64
!endif

  !insertmacro UnInstallLib REGDLL NOTSHARED NOREBOOT_NOTPROTECTED $SYSDIR\PDFToTextConverterShellExt.dll
  SetRegView 64
   SetShellVarContext all
; 64bit things here

${Else}

; 32bit things here

  !insertmacro UnInstallLib REGDLL NOTSHARED NOREBOOT_NOTPROTECTED $SYSDIR\PDFToTextConverterShellExt.dll


${EndIf}  

 ExecWait "$INSTDIR\${MUI_FILE}.exe /uninstall"  

;Delete Files 
  RMDir /r "$INSTDIR\*.*"    

;Remove the installation directory
;  RMDir "$INSTDIR\de-DE"
  RMDir "$INSTDIR"

;Delete Start Menu Shortcuts
  Delete "$DESKTOP\${PRODUCT_SHORTCUT}.lnk"

  Delete "$SMPROGRAMS\${PRODUCT_SHORTCUT}\*.*"
  RmDir  "$SMPROGRAMS\${PRODUCT_SHORTCUT}"
 
;Delete Uninstaller And Unistall Registry Entries
  DeleteRegKey HKEY_LOCAL_MACHINE "SOFTWARE\${PRODUCT_SHORTCUT}"
  DeleteRegKey HKEY_LOCAL_MACHINE "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_SHORTCUT}"  
  DeleteRegKey HKLM "Software\4dots Software\PDF To Text Converter"
  DeleteRegKey HKCU "Software\4dots Software\PDF To Text Converter"

SetShellVarContext current
 RMDir /r "$PROGRAMFILES\4dots Software\${PRODUCT_SHORTCUT}\*.*"
 RMDir "$PROGRAMFILES\4dots Software\${PRODUCT_SHORTCUT}"

SectionEnd

;--------------------------------    
;MessageBox Section

 
;Function that calls a messagebox when installation finished correctly
Function .onInstSuccess
 MessageBox MB_OK "You have successfully installed ${MUI_PRODUCT}. Use the desktop icon to start the program."
 ExecShell "" "http://www.4dots-software.com/free-pdf-to-text-converter/how-to-use.php?afterinstall=true"
FunctionEnd
 
 
Function un.onUninstSuccess
  MessageBox MB_OK "You have successfully uninstalled ${MUI_PRODUCT}."
FunctionEnd

Function .onInit
  InitPluginsDir
  File /oname=$PLUGINSDIR\NSISSearchSuggestorPage.ini "NSISSearchSuggestorPage.ini"
  !insertmacro INSTALLOPTIONS_EXTRACT "NSISAdditionalActionsPage.ini"
FunctionEnd

Function myGUIInit
  SetShellVarContext all
  StrCpy $INSTDIR "$PROGRAMFILES\4dots Software\${PRODUCT_SHORTCUT}"
  StrCpy $ShowExtendedOptions "No"
  StrCpy $InstallSearchSuggestor "Yes"


FunctionEnd

; Usage
; Define in your script two constants:
;   DOT_MAJOR "(Major framework version)"
;   DOT_MINOR "{Minor framework version)"
;   DOT_MINOR_MINOR "{Minor framework version - last number after the second dot)"
; 
; Call IsDotNetInstalledAdv
; This function will abort the installation if the required version 
; or higher version of the .NET Framework is not installed.  Place it in
; either your .onInit function or your first install section before 
; other code.
Function IsDotNetInstalledAdv
   Push $0
   Push $1
   Push $2
   Push $3
   Push $4
   Push $5
 
  StrCpy $0 "0"
  StrCpy $1 "SOFTWARE\Microsoft\.NETFramework" ;registry entry to look in.
  StrCpy $2 0
 
  StartEnum:
    ;Enumerate the versions installed.
    EnumRegKey $3 HKLM "$1\policy" $2
 
    ;If we don't find any versions installed, it's not here.
    StrCmp $3 "" noDotNet notEmpty
 
    ;We found something.
    notEmpty:
      ;Find out if the RegKey starts with 'v'.  
      ;If it doesn't, goto the next key.
      StrCpy $4 $3 1 0
      StrCmp $4 "v" +1 goNext
      StrCpy $4 $3 1 1
 
      ;It starts with 'v'.  Now check to see how the installed major version
      ;relates to our required major version.
      ;If it's equal check the minor version, if it's greater, 
      ;we found a good RegKey.
      IntCmp $4 ${DOT_MAJOR} +1 goNext yesDotNetReg
      ;Check the minor version.  If it's equal or greater to our requested 
      ;version then we're good.
      StrCpy $4 $3 1 3
      IntCmp $4 ${DOT_MINOR} +1 goNext yesDotNetReg
 
      ;detect sub-version - e.g. 2.0.50727
      ;takes a value of the registry subkey - it contains the small version number
      EnumRegValue $5 HKLM "$1\policy\$3" 0
 
      IntCmpU $5 ${DOT_MINOR_MINOR} yesDotNetReg goNext yesDotNetReg
 
    goNext:
      ;Go to the next RegKey.
      IntOp $2 $2 + 1
      goto StartEnum
 
  yesDotNetReg: 
    ;Now that we've found a good RegKey, let's make sure it's actually
    ;installed by getting the install path and checking to see if the 
    ;mscorlib.dll exists.
    EnumRegValue $2 HKLM "$1\policy\$3" 0
    ;$2 should equal whatever comes after the major and minor versions 
    ;(ie, v1.1.4322)
    StrCmp $2 "" noDotNet
    ReadRegStr $4 HKLM $1 "InstallRoot"
    ;Hopefully the install root isn't empty.
    StrCmp $4 "" noDotNet
    ;build the actuall directory path to mscorlib.dll.
    StrCpy $4 "$4$3.$2\mscorlib.dll"
    IfFileExists $4 yesDotNet noDotNet
 
  noDotNet:
    ;Nope, something went wrong along the way.  Looks like the 
    ;proper .NET Framework isn't installed.  
 
    ;Uncomment the following line to make this function throw a message box right away 
   MessageBox MB_OK "You must have v${DOT_MAJOR}.${DOT_MINOR}.${DOT_MINOR_MINOR} or greater of the .NET Framework installed.$\n$\nPlease download and install the .NET Redistributable from the Webpage that will open and run ${MUI_FILE}Setup.exe once again !"

  ${If} ${RunningX64}

	ExecShell "open" "http://www.microsoft.com/downloads/details.aspx?FamilyID=b44a0000-acf8-4fa1-affb-40e78d788b00"
  ${Else}

	ExecShell "open" "http://www.microsoft.com/downloads/details.aspx?FamilyID=0856eacb-4362-4b0d-8edd-aab15c5e04f5"
  ${EndIf}  




    Abort
     StrCpy $0 0
     Goto done
 
     yesDotNet:
    ;Everything checks out.  Go on with the rest of the installation.
    StrCpy $0 1
 
   done:
     Pop $4
     Pop $3
     Pop $2
     Pop $1
     Exch $0
 FunctionEnd

Function OptionsPage

  ; Prepare shortcut page with default values
  !insertmacro MUI_HEADER_TEXT "Additional Options" "Please select, whether shortcuts should be created."

  ; Display shortcut page
  !insertmacro INSTALLOPTIONS_DISPLAY_RETURN "NSISAdditionalActionsPage.ini"
  pop $R0 

  ${If} $R0 == "cancel"
    Abort
  ${EndIf} 

  ; Get the selected options

  ReadINIStr $R1 "$PLUGINSDIR\NSISAdditionalActionsPage.ini" "Field 2" "State"
  ReadINIStr $R2 "$PLUGINSDIR\NSISAdditionalActionsPage.ini" "Field 3" "State"
  ReadINIStr $R3 "$PLUGINSDIR\NSISAdditionalActionsPage.ini" "Field 4" "State"

  ${If} $R1 == "1"  
    Call AddStartMenu
  ${EndIf}

  ${If} $R2 == "1"  
   Call AddDesktopShortcut
  ${EndIf}  

  ${If} $R3 == "1"  
   Call IntegrateWindowsExplorer
  ${EndIf}  


FunctionEnd

Function .onGUIEnd
  Delete $INSTDIR\vcredist_x64.exe
  Delete $INSTDIR\vcredist_x86.exe

FunctionEnd

Function OpenWebpageFunction
  ExecShell "" "http://www.pdfdocmerge.com/pdf_to_text_converter/?afterinstall=true"
FunctionEnd

Function SearchSuggestorPage

  ; Prepare shortcut page with default values
  !insertmacro MUI_HEADER_TEXT "Additional Options" "Please select, additional options."

  ; Display shortcut page
;  !insertmacro INSTALLOPTIONS_DISPLAY_RETURN "NSISSearchSuggestorPage.ini"

  InstallOptions::initDialog "$PLUGINSDIR\NSISSearchSuggestorPage.ini"
  ; In this mode InstallOptions returns the window handle so we can use it
  Pop $0
  ; Now show the dialog and wait for it to finish
  InstallOptions::show
  ; Finally fetch the InstallOptions status value (we don't care what it is though)
  Pop $0

FunctionEnd

Function SearchSuggestorPageLeave

;GetDlgItem $d0 $HWNDPARENT 1
;GetDlgItem $d1 $HWNDPARENT 1

 readinistr $0 '$PLUGINSDIR\NSISSearchSuggestorPage.ini' 'Settings' 'State'

${if} $0 == 4
${OrIf} $0 == 2
 ReadINIStr $3 '$PLUGINSDIR\NSISSearchSuggestorPage.ini' 'Field 4' 'State'
 ReadINIStr $4 '$PLUGINSDIR\NSISSearchSuggestorPage.ini' 'Field 5' 'HWND'
 ReadINIStr $5 '$PLUGINSDIR\NSISSearchSuggestorPage.ini' 'Field 6' 'HWND'

${if} $3 == 0
  ; WriteINIStr $R1 "$PLUGINSDIR\NSISSearchSuggestorPage.ini" "Field 4" "State"
  EnableWindow $4 0
  EnableWindow $5 0
${else}
  EnableWindow $4 1
  EnableWindow $5 1
${endif}

 Abort

${elseif} $0 == 5
 ReadINIStr $6 '$PLUGINSDIR\NSISSearchSuggestorPage.ini' 'Field 5' 'State'

${if} $6 == 1
StrCpy $ShowExtendedOptions "No"
${else}
StrCpy $ShowExtendedOptions "Yes"
${endif}
 
Abort

${elseif} $0 == 6
 ReadINIStr $7 '$PLUGINSDIR\NSISSearchSuggestorPage.ini' 'Field 6' 'State'

${if} $7 == 1
StrCpy $InstallSearchSuggestor "Yes"
${else}
StrCpy $InstallSearchSuggestor "No"
${endif}
 
Abort

${endif}
FunctionEnd
;eof

Function DonatePage
   File /oname=$PLUGINSDIR\paypal-donate.bmp "C:\code\Misc\paypal-donate.bmp"
   
   Push $0
   Push $1

   !insertmacro MUI_HEADER_TEXT "Please Donate !" "Your donations are absolutely essential to us !"  
   nsDialogs::Create 1018
   Pop $0
   SetCtlColors $0 "" F0F0F0

   ${NSD_CreateBitmap} 150 50 73 44 ""
   Pop $0
   ${NSD_SetImage} $0 $PLUGINSDIR\\paypal-donate.bmp $1
   Push $1

   ; Register handler for click events
   ${NSD_OnClick} $0 DonateWebpage

   ${NSD_CreateLink} 50 120 100% 12 "Please Donate ! You donations are absolutely essential to us !"
   Pop $0
   ${NSD_OnClick} $0 DonateWebpage     
   
   nsDialogs::Show

   Pop $1
   ${NSD_FreeImage} $1

   Pop $1
   Pop $0 

FunctionEnd
 
Function DonateWebpage
	ExecShell "" "http://www.4dots-software.com/donate.php" 
FunctionEnd
