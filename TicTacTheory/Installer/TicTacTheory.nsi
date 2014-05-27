!define PRODUCT_NAME "TTTheory"
!define SETUP_NAME "TTTSetup.exe"
!define PRODUCT_VERSION "1.0"

OutFile ${SETUP_NAME}
Name "${PRODUCT_NAME} ${PRODUCT_VERSION}"

; Default installation folder.
InstallDir "$PROGRAMFILES\BoardGameTheory\TicTacTheory"

Section "Dummy Section" SecDummy
; Define output path.
SetOutPath $INSTDIR


; Get installation folder from registry if available.
; InstallDirRegKey HKLM

; Specify files to go in output path.
File "..\bin\Release\TicTacTheory.exe"
File "..\bin\Release\BoardGameCore.dll"
File "..\bin\Release\SharpSearch.dll"
File "..\bin\Release\TicTacTheory.pdb"
File "..\bin\Release\BoardGameCore.pdb"
File "..\bin\Release\SharpSearch.pdb"

SectionEnd

ShowInstDetails show
ShowUnInstDetails show

; Request application privileges for Windows Vista.
RequestExecutionLevel user