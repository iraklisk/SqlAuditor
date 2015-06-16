msbuild SqlAuditor.sln /t:Rebuild /p:Configuration=Deploy /m
del /a Deploy\SqlAuditor\*.pdb
cd Deploy
del /a SqlAuditor.zip
..\ThirdPartyUtils\7z.exe a -tzip "SqlAuditor.zip" SqlAuditor\* -mx9
