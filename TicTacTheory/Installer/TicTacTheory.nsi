!define PRODUCT_NAME "TicTacTheory"
!define SETUP_NAME "TTTSetup.exe"
!define PRODUCT_VERSION "1.0"

; Request application privileges.
RequestExecutionLevel admin

; Default installation folder.
InstallDir "$PROGRAMFILES\BoardGameTheory\TicTacTheory"

Name "${PRODUCT_NAME} ${PRODUCT_VERSION}"
OutFile ${SETUP_NAME}

!include LogicLib.nsh

page directory
page instfiles

!macro VerifyUserIsAdmin
UserInfo::GetAccountType
pop $0
${If} $0 != "admin" ;Require admin rights on NT4+
        messageBox mb_iconstop "Administrator rights required!"
        setErrorLevel 740 ;ERROR_ELEVATION_REQUIRED
        quit
${EndIf}
!macroend


Section "Install Section" SecInstall
; Define output path.
SetOutPath $INSTDIR

; Specify files to go in output path.
File "..\bin\Release\TicTacTheory.exe"
File "..\bin\Release\BoardGameCore.dll"
File "..\bin\Release\SharpSearch.dll"
File "..\bin\Release\TicTacTheory.pdb"
File "..\bin\Release\BoardGameCore.pdb"
File "..\bin\Release\SharpSearch.pdb"

; Uninstaller - See function un.onInit and section "uninstall" for configuration.
writeUninstaller "$INSTDIR\uninstall.exe"

SectionEnd ; Install

# Uninstaller

function un.onInit
	SetShellVarContext all

	#Verify the uninstaller - last chance to back out
	MessageBox MB_OKCANCEL "Permanantly remove ${PRODUCT_NAME}?" IDOK next
		Abort
	next:
	!insertmacro VerifyUserIsAdmin
functionEnd ; un.onInit

section "Uninstall" SecUninstall

	# Remove files
	delete $INSTDIR\TicTacTheory.exe
	delete $INSTDIR\BoardGameCore.dll
	delete $INSTDIR\SharpSearch.dll
	delete $INSTDIR\TicTacTheory.pdb
	delete $INSTDIR\BoardGameCore.pdb
	delete $INSTDIR\SharpSearch.pdb

	# Always delete uninstaller as the last action
	delete $INSTDIR\uninstall.exe

	# Try to remove the install directory - this will only happen if it is empty
	rmDir $INSTDIR

sectionEnd ; Uninstall

ShowInstDetails show
ShowUnInstDetails show

