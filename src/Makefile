TEST_DATA=profiler/data100.txt
DIR=xhofma11_xmoskv01_xskypa03
BUILD=dotnet build
CALC_PATH=ui\bin\Debug\net8.0-windows10.0.19041.0\win10-x64
OBJ=obj
PLATFORMS=Platforms
BIN=bin
REPO=repo

.PHONY: all pack build run profile clean

all: build run

pack: clean
	@mkdir ..\..\"$(DIR)"
	@mkdir ..\..\"$(DIR)\install"
	@mkdir ..\..\"$(DIR)\repo"
	@mkdir ..\..\"$(DIR)\doc"
	@copy installer\Calculadora.exe ..\..\"$(DIR)"\install
	@copy installer\stddev.exe ..\..\"$(DIR)"\install
	@xcopy doc ..\..\"$(DIR)\doc" /E
	@xcopy ..\  ..\..\"$(DIR)"\repo /E
	@cd ..\..\ && tar -acvf "$(DIR)".zip "$(DIR)
	


build:
	@cd ui && $(BUILD)

run:
	.\$(CALC_PATH)\calculadora.exe	

profile:
	cd profiler && dotnet build
	.\profiler\bin\Debug\net6.0-windows\Profiler.exe < $(TEST_DATA)

clean:
	@if exist .vs (rd /s /q .vs)
	@if exist ..\.vs (rd /s /q ..\.vs)

	@if exist ui\$(BIN) (rd /s /q ui\$(BIN))
	@if exist ui\$(OBJ) (rd /s /q ui\$(OBJ))
	@if exist ui\.vs (rd /s /q ui\.vs)

	@if exist Calculator\$(BIN) (rd /s /q Calculator\$(BIN))
	@if exist Calculator\$(OBJ) (rd /s /q Calculator\$(OBJ))
	@if exist Calculator\.vs (rd /s /q Calculator\.vs)

	@if exist profiler\$(BIN) (rd /s /q profiler\$(BIN))
	@if exist profiler\$(OBJ) (rd /s /q profiler\$(OBJ))
	@if exist profiler\.vscode (rd /s /q profiler\.vscode)
	@if exist profiler\.vs (rd /s /q profiler\.vs)
	
	@if exist testlib\$(BIN) (rd /s /q testlib\$(BIN))
	@if exist testlib\$(OBJ) (rd /s /q testlib\$(OBJ))
	@if exist testlib\TestResults (rd /s /q testlib\TestResults)
	@if exist testlib\.vs (rd /s /q testlib\.vs)


	@if exist ..\..\"$(DIR)" (rd /s /q ..\..\"$(DIR)")



help:
	@echo   make all        (spusti program)
	@echo   make            (provede se make all)
	@echo   pack            (zabali projekt tak, aby mohl byt odevzdan)
	@echo   clean           (smaze vsechny soubory, co nemaji byt odevzdany)
	@echo   run             (spusti program)
	@echo   profile         (spusti program pro vypocet smerodatne odchylky s ukazkovym testovacim vstupem)
	@echo   help            (vypise napovedu s popisem, co je potreba udelat pred spustenim programu)
