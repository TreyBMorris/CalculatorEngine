# CalculatorDOTNET

# Introduction
This is a .NET 8 application, that is similar to my semester project written in Java that you can find [here](https://github.com/TreyBMorris/SWE3643TestingProject). 

#### Table of Contents
- [Why?](#why)
- [Development Environment](#development-environment)
- [Architecture](#architecture)
- [Executing Unit Tests](#executing-unit-tests)
- [Deployment](#deployment)


## Why? 
After completing my project for the semester, I wanted to challenge myself to see if I can replicate the project again but doing it my own way. To start, the challenge was to rewrite the backend code for the project. .NET has always been something I have wanted to grow my abilities in. With this the backend is being developed in .NET. The buisiness logic, unit tests, and RESTful API are hosted on this repository. The goal is to deploy the backend as a full API, and rewrite the frontend interface in different frameworks. Notably, one front end will be written in Angular using TypeScript. Afterwards, the goal will be to use other frontend frameworks or plain JavaScript to develop the frontend. This way, I am learning about both the frontend and backend side of a project so that I can pursue my interest in being a full-stack developer.

## Development Environment
This application is being developed on a Windows using Visual Studio 2022. I am using GitHub actions to run the NUnit unit tests in my repository, to make sure that when new code is pushed that all tests are passing and that bad code is not being pushed. The goal for when the project is finished, is to deploy it on the web as an API, where a frontend application will be able to make HTTP requests.

## Architecture
This application will have similar architecture as the previous project, but will not have a UI or end-to-end tests in this repository. The end-to-end tests and frontend UI will have its own repository and will be linked to this repository when finished.
[image here]()


## Executing Unit Tests
1. Clone the git repository above using the blue code button. You can use GitHub desktop, downloading the zip file, or the git CLI to clone this repository.
2. Navigate into the repository directory.
3. Restore the dependencies for the repository with the following command,
```bash
dotnet restore
```

4. After restoring the dependencies for the repository, run the build command to build the solution.
```bash
dotnet build
```

5. After the build is complete, run the test command to run the unit tests.
```bash
dotnet test
```

6. View the test results, if there are any failures they will be present, otherwise all tests should pass by default.


## Deployment
For deployment, Azure was chosen to keep within the .NET environment. (I also have a student subscription through my school). The reason for deployment is so that when a front-end is created the server will not need to be running locally, but can be in the cloud so that it can be accessed at all time. This way, regardless of front-end framework (Vanilla JS, Angular, React, etc.) one can easily access the API and use it for their application.
