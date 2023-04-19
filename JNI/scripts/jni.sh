#!/bin/bash

# Set the project directory
PROJ_DIR=$1

# Substituir barras invertidas por barras
PROJ_DIR="${PROJ_DIR//\\//}"

# Extrair o nome do projeto a partir do caminho do projeto
PROJ_NAME=$(basename "$PROJ_DIR")

# Change to the project directory
cd "$PROJ_DIR/src" || exit

# Create the header file
javac -h . "$PROJ_NAME.java"

# Compile the C file
JDK_DIR="/home/diogo/.jdks/openjdk-20/include"
DLL_NAME="${PROJ_NAME/JNI/}"

gcc -I "$JDK_DIR" -I "$JDK_DIR/win32" -shared -o "$DLL_NAME.dll" "$PROJ_NAME.c"

# Run the Java file
java -classpath . "$PROJ_NAME"
