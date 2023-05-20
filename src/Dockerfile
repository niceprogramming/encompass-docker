#escape=`

FROM mcr.microsoft.com/dotnet/framework/runtime:4.8-windowsservercore-ltsc2019

RUN `
    curl -fSLo encompass-sdk.msi https://download.elliemae.com/encompass/updates/23.1.0/encompass23106sdk.msi `
    && .\encompass-sdk.msi /qn `
    && del .\encompass-sdk.msi `
    && powershell Remove-Item -Force -Recurse ${Env:TEMP}\* 

RUN reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Ellie Mae\Encompass\SDK" /v License /t REG_BINARY /d 24170e09f5f6efe0cdaedce5f2061a2f32363e48518b9dafb4b7c1cd013b4f /f `
    && reg add "HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Ellie Mae\Encompass\SDK" /v License /t REG_BINARY /d 24170e09f5f6efe0cdaedce5f2061a2f32363e48518b9dafb4b7c1cd013b4f /f

RUN reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Ellie Mae\Encompass" /v InstallDir /t REG_SZ /d "C:\Program Files (x86)\Encompass\\" /f `
    && reg add "HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Ellie Mae\Encompass" /v InstallDir /t REG_SZ /d "C:\Program Files (x86)\Encompass\\" /f