# example-remote-powershell
Aplicación de ejemplo para ejecutar comando powershell

# Puntos Importantes
1.- Se debe instalar Windows Management Framework 3.0. Con esto, se instalará powershell 3.0
2.- En visual studio, se debe agregar el paquete NUGET Microsoft.PowerShell.3.ReferenceAssemblies
3.- En el archivo de recursos, se debe configurar donde vivirá la aplicación servidor de ejemplo que es invocada
4.- En el equipo dese el cual se ejecutarán los comandos powershell, se debe primero correr los siguientes comandos:
```
Enable-PSRemoting -Force
Set-Item wsman:\localhost\client\trustedhosts *
Restart-Service WinRM
```

# Referencias
https://www.howtogeek.com/117192/how-to-run-powershell-commands-on-remote-computers/