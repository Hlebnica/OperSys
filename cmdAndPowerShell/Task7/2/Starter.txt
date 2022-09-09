set /p subdir_name=<dir_name.txt
cd %subdir_name%
for %%i in (a*) do ren "%%i" "%1_%%~nxi"
pause