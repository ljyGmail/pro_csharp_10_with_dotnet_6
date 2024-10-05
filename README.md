# Create solutions and projects using VSCode

## 1. Create a solution
dotnet new sln -n {solution name} -o {solution directory}

## 2. Create a project
cd {solution directory}
dotnet new console -lang c# -n {project name} -o {project path} 

## 3. Add the project to the solution
dotnet sln {solution file} add {project path}

## 4. Run specified project
dotnet run --project {project path}
