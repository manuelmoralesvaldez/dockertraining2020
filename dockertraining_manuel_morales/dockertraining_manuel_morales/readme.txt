NOTES:
-I were not able to instal Docker Desktop my laptop is running windows 10 home
-I had to work using old docker utilities.
-I only can work with linux containers that's why in 
   C:\Users\ManuelMorales\source\repos\dockertraining_manuel_morales\dockertraining_manuel_morales\dockertraining_manuel_morales.csproj
   exists the  entry  <DockerDefaultTargetOS>Linux</DockerDefaultTargetOS>
- I cant use mcr.microsoft.com/dotnet/core/aspnet:3.1-nanoserver-1903 i had to change it 


-- command 1 , moe the to the directory where dockerfile is located
cd  /c/users/ManuelMorales/source/repos/dockertraining_manuel_morales/dockertraining_manuel_morales

--  command 2 create the image usign the docer file
$ docker build -t assesment:latest . 

--command 3
$ docker run --name "Site1" -p 8085:80  assesment

-- command 4
$ docker run --name "Site1" -p 8085:80  assesment

-- command 5
$ docker run --name "Site2" -p 8086:80 --env STORENAME=Plano  assesment

.. command 6
-- this isd for "renaming" the local image for pushing to docket hub
$ docker tag 4dd31ffbef7e dockertraining2020/dockertrainingmanuelmorales 
