# Create sln in dir
dotnet new sln -n mandiri

# Create service
* example Service Book, Service Author, Service Category, Service Publisher
dotnet new webapi -o ./src/Book.Service -f netcoreapp3.1
dotnet new webapi -o ./src/Author.Service -f netcoreapp3.1
dotnet new webapi -o ./src/Category.Service  -f netcoreapp3.1
dotnet new webapi -o ./src/Publisher.Service -f netcoreapp3.1

# Add to sln
dotnet sln add ./src/Book.Service
dotnet sln add ./src/Author.Service
dotnet sln add ./src/Category.Service
dotnet sln add ./src/Publisher.Service



# Launch.json
```
{
    "version": "0.2.0",
    "configurations": [
        {
            // Use IntelliSense to find out which attributes exist for C# debugging
            // Use hover for the description of the existing attributes
            // For further information visit https://github.com/OmniSharp/omnisharp-vscode/blob/master/debugger-launchjson.md
            "name": "Book .NET Core Launch (web)",
            "type": "coreclr",
            "request": "launch",
            "preLaunchTask": "build Book.Service",
            // If you have changed target frameworks, make sure to update the program path.
            "program": "${workspaceFolder}/src/Book.Service/bin/Debug/netcoreapp3.1/Book.Service.dll",
            "args": [],
            "cwd": "${workspaceFolder}/src/Book.Service",
            "stopAtEntry": false,
            // Enable launching a web browser when ASP.NET Core starts. For more information: https://aka.ms/VSCode-CS-LaunchJson-WebBrowser
            "serverReadyAction": {
                "action": "openExternally",
                "pattern": "\\bNow listening on:\\s+(https?://\\S+)"
            },
            "env": {
                "ASPNETCORE_ENVIRONMENT": "Development"
            },
            "sourceFileMap": {
                "/Views": "${workspaceFolder}/Views"
            }
        },
        {
            // Use IntelliSense to find out which attributes exist for C# debugging
            // Use hover for the description of the existing attributes
            // For further information visit https://github.com/OmniSharp/omnisharp-vscode/blob/master/debugger-launchjson.md
            "name": "Category .NET Core Launch (web)",
            "type": "coreclr",
            "request": "launch",
            "preLaunchTask": "build Category.Service",
            // If you have changed target frameworks, make sure to update the program path.
            "program": "${workspaceFolder}/src/Category.Service/bin/Debug/netcoreapp3.1/Category.Service.dll",
            "args": [],
            "cwd": "${workspaceFolder}/src/Category.Service",
            "stopAtEntry": false,
            // Enable launching a web browser when ASP.NET Core starts. For more information: https://aka.ms/VSCode-CS-LaunchJson-WebBrowser
            "serverReadyAction": {
                "action": "openExternally",
                "pattern": "\\bNow listening on:\\s+(https?://\\S+)"
            },
            "env": {
                "ASPNETCORE_ENVIRONMENT": "Development"
            },
            "sourceFileMap": {
                "/Views": "${workspaceFolder}/Views"
            }
        },
        {
            // Use IntelliSense to find out which attributes exist for C# debugging
            // Use hover for the description of the existing attributes
            // For further information visit https://github.com/OmniSharp/omnisharp-vscode/blob/master/debugger-launchjson.md
            "name": "Publisher .NET Core Launch (web)",
            "type": "coreclr",
            "request": "launch",
            "preLaunchTask": "build Publisher.Service",
            // If you have changed target frameworks, make sure to update the program path.
            "program": "${workspaceFolder}/src/Publisher.Service/bin/Debug/netcoreapp3.1/Publisher.Service.dll",
            "args": [],
            "cwd": "${workspaceFolder}/src/Publisher.Service",
            "stopAtEntry": false,
            // Enable launching a web browser when ASP.NET Core starts. For more information: https://aka.ms/VSCode-CS-LaunchJson-WebBrowser
            "serverReadyAction": {
                "action": "openExternally",
                "pattern": "\\bNow listening on:\\s+(https?://\\S+)"
            },
            "env": {
                "ASPNETCORE_ENVIRONMENT": "Development"
            },
            "sourceFileMap": {
                "/Views": "${workspaceFolder}/Views"
            }
        },
        {
            // Use IntelliSense to find out which attributes exist for C# debugging
            // Use hover for the description of the existing attributes
            // For further information visit https://github.com/OmniSharp/omnisharp-vscode/blob/master/debugger-launchjson.md
            "name": "Author .NET Core Launch (web)",
            "type": "coreclr",
            "request": "launch",
            "preLaunchTask": "build Author.Service",
            // If you have changed target frameworks, make sure to update the program path.
            "program": "${workspaceFolder}/src/Author.Service/bin/Debug/netcoreapp3.1/Author.Service.dll",
            "args": [],
            "cwd": "${workspaceFolder}/src/Author.Service",
            "stopAtEntry": false,
            // Enable launching a web browser when ASP.NET Core starts. For more information: https://aka.ms/VSCode-CS-LaunchJson-WebBrowser
            "serverReadyAction": {
                "action": "openExternally",
                "pattern": "\\bNow listening on:\\s+(https?://\\S+)"
            },
            "env": {
                "ASPNETCORE_ENVIRONMENT": "Development"
            },
            "sourceFileMap": {
                "/Views": "${workspaceFolder}/Views"
            }
        },
        {
            // Use IntelliSense to find out which attributes exist for C# debugging
            // Use hover for the description of the existing attributes
            // For further information visit https://github.com/OmniSharp/omnisharp-vscode/blob/master/debugger-launchjson.md
            "name": "Auth .NET Core Launch (web)",
            "type": "coreclr",
            "request": "launch",
            "preLaunchTask": "build Auth.Service",
            // If you have changed target frameworks, make sure to update the program path.
            "program": "${workspaceFolder}/src/Auth.Service/bin/Debug/netcoreapp3.1/Auth.Service.dll",
            "args": [],
            "cwd": "${workspaceFolder}/src/Auth.Service",
            "stopAtEntry": false,
            // Enable launching a web browser when ASP.NET Core starts. For more information: https://aka.ms/VSCode-CS-LaunchJson-WebBrowser
            "serverReadyAction": {
                "action": "openExternally",
                "pattern": "\\bNow listening on:\\s+(https?://\\S+)"
            },
            "env": {
                "ASPNETCORE_ENVIRONMENT": "Development"
            },
            "sourceFileMap": {
                "/Views": "${workspaceFolder}/Views"
            }
        },
    ]
}
```

# Task.json
```
{
    "version": "2.0.0",
    "tasks": [
        {
            "label": "build Book.Service",
            "command": "dotnet",
            "type": "process",
            "args": [
                "build",
                "${workspaceFolder}/src/Book.Service/Book.Service.csproj",
                "/property:GenerateFullPaths=true",
                "/consoleloggerparameters:NoSummary"
            ],
            "problemMatcher": "$msCompile"
        },
        {
            "label": "publish Book.Service",
            "command": "dotnet",
            "type": "process",
            "args": [
                "publish",
                "${workspaceFolder}/src/Book.Service/Book.Service.csproj",
                "/property:GenerateFullPaths=true",
                "/consoleloggerparameters:NoSummary"
            ],
            "problemMatcher": "$msCompile"
        },
        {
            "label": "watch Book.Service",
            "command": "dotnet",
            "type": "process",
            "args": [
                "watch",
                "run",
                "--project",
                "${workspaceFolder}/src/Book.Service/Book.Service.csproj"
            ],
            "problemMatcher": "$msCompile"
        },
        {
            "label": "build Category.Service",
            "command": "dotnet",
            "type": "process",
            "args": [
                "build",
                "${workspaceFolder}/src/Category.Service/Category.Service.csproj",
                "/property:GenerateFullPaths=true",
                "/consoleloggerparameters:NoSummary"
            ],
            "problemMatcher": "$msCompile"
        },
        {
            "label": "publish Category.Service",
            "command": "dotnet",
            "type": "process",
            "args": [
                "publish",
                "${workspaceFolder}/src/Category.Service/Category.Service.csproj",
                "/property:GenerateFullPaths=true",
                "/consoleloggerparameters:NoSummary"
            ],
            "problemMatcher": "$msCompile"
        },
        {
            "label": "watch Category.Service",
            "command": "dotnet",
            "type": "process",
            "args": [
                "watch",
                "run",
                "--project",
                "${workspaceFolder}/src/Category.Service/Category.Service.csproj"
            ],
            "problemMatcher": "$msCompile"
        },
        {
            "label": "build Publisher.Service",
            "command": "dotnet",
            "type": "process",
            "args": [
                "build",
                "${workspaceFolder}/src/Publisher.Service/Publisher.Service.csproj",
                "/property:GenerateFullPaths=true",
                "/consoleloggerparameters:NoSummary"
            ],
            "problemMatcher": "$msCompile"
        },
        {
            "label": "publish Publisher.Service",
            "command": "dotnet",
            "type": "process",
            "args": [
                "publish",
                "${workspaceFolder}/src/Publisher.Service/Publisher.Service.csproj",
                "/property:GenerateFullPaths=true",
                "/consoleloggerparameters:NoSummary"
            ],
            "problemMatcher": "$msCompile"
        },
        {
            "label": "watch Publisher.Service",
            "command": "dotnet",
            "type": "process",
            "args": [
                "watch",
                "run",
                "--project",
                "${workspaceFolder}/src/Publisher.Service/Publisher.Service.csproj"
            ],
            "problemMatcher": "$msCompile"
        },
        {
            "label": "build Author.Service",
            "command": "dotnet",
            "type": "process",
            "args": [
                "build",
                "${workspaceFolder}/src/Author.Service/Author.Service.csproj",
                "/property:GenerateFullPaths=true",
                "/consoleloggerparameters:NoSummary"
            ],
            "problemMatcher": "$msCompile"
        },
        {
            "label": "publish Author.Service",
            "command": "dotnet",
            "type": "process",
            "args": [
                "publish",
                "${workspaceFolder}/src/Author.Service/Author.Service.csproj",
                "/property:GenerateFullPaths=true",
                "/consoleloggerparameters:NoSummary"
            ],
            "problemMatcher": "$msCompile"
        },
        {
            "label": "watch Author.Service",
            "command": "dotnet",
            "type": "process",
            "args": [
                "watch",
                "run",
                "--project",
                "${workspaceFolder}/src/Author.Service/Author.Service.csproj"
            ],
            "problemMatcher": "$msCompile"
        },
        {
            "label": "build Auth.Service",
            "command": "dotnet",
            "type": "process",
            "args": [
                "build",
                "${workspaceFolder}/src/Auth.Service/Auth.Service.csproj",
                "/property:GenerateFullPaths=true",
                "/consoleloggerparameters:NoSummary"
            ],
            "problemMatcher": "$msCompile"
        },
        {
            "label": "publish Auth.Service",
            "command": "dotnet",
            "type": "process",
            "args": [
                "publish",
                "${workspaceFolder}/src/Auth.Service/Auth.Service.csproj",
                "/property:GenerateFullPaths=true",
                "/consoleloggerparameters:NoSummary"
            ],
            "problemMatcher": "$msCompile"
        },
        {
            "label": "watch Auth.Service",
            "command": "dotnet",
            "type": "process",
            "args": [
                "watch",
                "run",
                "--project",
                "${workspaceFolder}/src/Auth.Service/Auth.Service.csproj"
            ],
            "problemMatcher": "$msCompile"
        }
    ]
}
```