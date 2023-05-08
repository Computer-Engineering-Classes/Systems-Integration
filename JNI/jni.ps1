Param(
    [string]$Dir
)

$PROJ_NAME = (Get-Item $Dir).BaseName
$PROJ_DIR = (Join-Path $Dir "src")

$OLDPWD = Get-Location
Set-Location -Path $PROJ_DIR -ErrorAction Stop

Write-Host "Creating header file..."
javac -h . "$PROJ_NAME.java"

$JDK_DIR = "$Env:JAVA_HOME\include"
$DLL_NAME = $PROJ_NAME -replace "JNI", ""

Write-Host "Compiling C file..."
gcc -I $JDK_DIR -I (Join-Path $JDK_DIR "win32") -shared -o "$DLL_NAME.dll" "$PROJ_NAME.c"

Write-Host "Running Java file..."
java -classpath . "$PROJ_NAME"

Set-Location -Path $OLDPWD -ErrorAction Stop