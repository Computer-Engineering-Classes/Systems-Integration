Param(
    [string]$Dir,
    [string]$Name
)

$PROJ_DIR = $Dir
$PROJ_NAME = $Name

$OLDPWD = Get-Location
Set-Location -Path $PROJ_DIR -ErrorAction Stop

Write-Host "Creating header file..."
javac -h . "$PROJ_NAME.java"

$JDK_DIR = "C:\Users\diogo\.jdks\openjdk-20\include"
$DLL_NAME = $PROJ_NAME -replace "JNI", ""

Write-Host "Compiling C file..."
gcc -I $JDK_DIR -I (Join-Path $JDK_DIR "win32") -shared -o "$DLL_NAME.dll" "$PROJ_NAME.c"

Write-Host "Running Java file..."
java -classpath . "$PROJ_NAME"

Set-Location -Path $OLDPWD -ErrorAction Stop