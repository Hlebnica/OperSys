set subdir_name=task7dir1
cd %subdir_name%
for %%i in (a*) do ren "%%i" "%1_%%~nxi"
pause