# Quinntyne

## Overview
Quinntyne is an Angular 21 application with Jest for unit testing and Playwright for end-to-end (e2e) testing.

## Getting Started

### Install dependencies
```sh
npm install --prefix src/Quinntyne.App
```

### Run the Angular app
```sh
npm start --prefix src/Quinntyne.App
```

### Run unit tests (Jest)
```sh
npm test --prefix src/Quinntyne.App
```

### Run e2e tests (Playwright)
```sh
npx playwright test --prefix src/Quinntyne.App
```

## Continuous Integration
On every merge or pull request to `main`, GitHub Actions will:
- Install dependencies
- Run Jest unit tests
- Build the Angular app
- Install Playwright browsers
- Start the Angular dev server
- Run Playwright e2e tests

## Main Page Example
The main page displays:
```
<h1>Quinntyne Brown</h1>
<h2>Senior .NET Consultant / Architect</h2>
```