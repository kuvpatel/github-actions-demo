# GitHub Actions Demo

A simple .NET 9 console application used to demonstrate and learn GitHub Actions.

The application itself is intentionally simple. The main purpose of this project is to gradually introduce different GitHub Actions features and CI/CD concepts.

## Technologies

* .NET 9
* C#
* xUnit
* GitHub Actions
* GitHub

## Project Structure

```text
GitHubActionsDemo
│
├── .github
│   └── workflows
│       └── build.yml
│
├── src
│   └── GitHubActionsDemo
│       ├── Program.cs
│       ├── Customer.cs
│       └── CustomerService.cs
│
├── tests
│   └── GitHubActionsDemo.Tests
│       └── CustomerServiceTests.cs
│
├── .gitignore
└── GitHubActionsDemo.sln
```

## Application

The application contains a simple customer model and service.

### Customer

The `Customer` class contains:

* Id
* First name
* Last name
* Email

### CustomerService

The `CustomerService` currently provides a simple operation to return a customer's full name.

## Unit Tests

The project uses **xUnit** for unit testing.

Tests can be run locally with:

```bash
dotnet test
```

## GitHub Actions

The project currently contains a CI workflow:

```text
.github/workflows/build.yml
```

The workflow runs when:

* Code is pushed to `main`
* A Pull Request is created or updated targeting `main`

### Current Workflow

```text
Push / Pull Request
        │
        ▼
Checkout code
        │
        ▼
Setup .NET 9
        │
        ▼
Restore dependencies
        │
        ▼
Build
        │
        ▼
Test
        │
        ▼
Publish
        │
        ▼
Upload artifact
```

### Build

The workflow uses `actions/checkout` to retrieve the source code and `actions/setup-dotnet` to configure .NET 9.

The application is then restored and built:

```bash
dotnet restore
dotnet build --no-restore
```

### Test

The unit tests are executed as part of the CI workflow:

```bash
dotnet test --no-build --verbosity normal
```

If the tests fail, the workflow fails.

### Publish

The application is published using:

```bash
dotnet publish src/GitHubActionsDemo/GitHubActionsDemo.csproj \
  --configuration Release \
  --output ./publish
```

### Artifact

The published application is uploaded as a GitHub Actions artifact using:

```yaml
uses: actions/upload-artifact@v4
```

The artifact can be downloaded from the GitHub Actions workflow run.

## Running Locally

Clone the repository and navigate to the project directory.

Restore dependencies:

```bash
dotnet restore
```

Build the solution:

```bash
dotnet build
```

Run the application:

```bash
dotnet run --project src/GitHubActionsDemo
```

Run the tests:

```bash
dotnet test
```

## GitHub Actions Learning Plan

This project will be extended gradually to demonstrate additional GitHub Actions features.

### Completed

* [x] Basic CI workflow
* [x] .NET 9 setup
* [x] Dependency restore
* [x] Application build
* [x] Unit tests
* [x] Pull Request validation
* [x] Application publishing
* [x] Workflow artifacts

### Planned

* [ ] NuGet dependency caching
* [ ] Manual workflow execution
* [ ] Scheduled workflows
* [ ] Environment variables
* [ ] GitHub Actions secrets
* [ ] Matrix builds
* [ ] Job dependencies
* [ ] Conditional jobs and steps
* [ ] Reusable workflows
* [ ] GitHub Environments
* [ ] Deployment
* [ ] Release automation

## Purpose

The goal of this repository is to provide a small, easy-to-understand project for experimenting with GitHub Actions and gradually building knowledge of CI/CD automation.
